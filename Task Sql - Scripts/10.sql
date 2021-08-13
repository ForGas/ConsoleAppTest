CREATE TABLE Account_Transactions (
	Id BIGINT IDENTITY (1, 1) NOT NUll,
	SenderClientId BIGINT NULL,
	SenderAccountId BIGINT NULL,
	RecipientClientId BIGINT NULL,
	RecipientAccountId BIGINT NULL,
	Sum DECIMAL(18,1) NULL,
	Operation NVARCHAR(10) NOT NULL CHECK(Operation IN('Withdraw', 'Put', 'Transfer')),
	PRIMARY KEY (Id)
);