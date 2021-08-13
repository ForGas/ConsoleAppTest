ALTER TABLE Accounts
ADD CONSTRAINT [FK_Accounts_To_Bank_Clients] FOREIGN KEY (ClientId) REFERENCES Bank_Clients (Id);