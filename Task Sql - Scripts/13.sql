CREATE TRIGGER Operation

ON Account_Transactions 

AFTER INSERT, UPDATE
AS
BEGIN

DECLARE @operation NVARCHAR(20), @sum decimal(18, 1), @balance decimal(18, 1)
SET @operation = (SELECT (Operation) FROM INSERTED)
SET @sum = (SELECT (Sum) FROM INSERTED)
SET @balance = (SELECT (Balance) FROM Accounts 
WHERE ClientId = (SELECT (SenderClientId) FROM INSERTED )
AND Id = (SELECT (SenderAccountId) FROM INSERTED ))

IF @operation = 'Transfer' AND @balance >= @sum
	BEGIN
		UPDATE Accounts
		SET Balance = Balance - @sum
		WHERE Id = (SELECT (SenderAccountId) FROM INSERTED )
		AND ClientId = (SELECT (SenderClientId) FROM INSERTED );

		UPDATE Accounts
		SET Balance = Balance + @sum
		WHERE Id = (SELECT (RecipientAccountId) FROM INSERTED )
		AND ClientId = (SELECT (RecipientClientId) FROM INSERTED )
	END

IF @operation = 'Put'
	BEGIN
		UPDATE Accounts
		SET Balance = Balance + @sum
		WHERE Id = (SELECT (SenderAccountId) FROM INSERTED )
		AND ClientId = (SELECT (SenderClientId) FROM INSERTED )
	END

IF @operation = 'Withdraw' AND @balance >= @sum
	BEGIN
		UPDATE Accounts
		SET Balance = Balance - @sum
		WHERE Id = (SELECT (SenderAccountId) FROM INSERTED )
		AND ClientId = (SELECT (SenderClientId) FROM INSERTED )
	END

ELSE
	BEGIN
		PRINT @operation + 'не найдена! ' + 'или у вас не достаточно баланса'
	END
END
