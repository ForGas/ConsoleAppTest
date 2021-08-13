INSERT INTO Accounts VALUES
((SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '123214213247'), '101', (1000.00) ),
((SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '623211213241'), '102', (1000.00) ),
((SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '223218213244'), '103', (1000.00) ),
((SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '423217213246'), '104', (1000.00) )

GO

INSERT INTO Account_Transactions VALUES
(
	(SELECT TOP 1 Id FROM Bank_Clients WHERE Iin = '123214213247'), 
	(SELECT TOP 1 Id FROM Accounts WHERE Number = '101'),
	NULL, NULL, (100.00), ('Put')
),
(
	(SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '623211213241'), 
	(SELECT TOP 1 (Id) FROM Accounts WHERE Number = '102'),
	NULL, NULL, 100, 'Withdraw'
),
(
	(SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '223218213244'), 
	(SELECT TOP 1 (Id) FROM Accounts WHERE Number = '103'),
	(SELECT TOP 1 (Id) FROM Bank_Clients WHERE Iin = '423217213246'), 
	(SELECT TOP 1 (Id) FROM Accounts WHERE Number = '104'), 
	100, 'Transfer'
)