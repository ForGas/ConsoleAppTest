INSERT INTO [dbo].[Countries] VALUES
('895', N'�������'), ('036', N'���������'), ('036', N'���������'),
('826', N'��������������'), ('348', N'�������'), ('332', N'�����'),
('276', N'��������'), ('376', N'�������'), ('724', N'�������'),
('124', N'������'), ('404', N'�����'), ('156', N'�����'),
('156', N'�����');

GO

INSERT INTO [dbo].[Cities] VALUES
('1', N'�����'), ('21', N'������'), ('21', N'������'),
('32', N'������'), ('31', N'��������'), ('33', N'������'),
('27', N'������'), ('37', N'����-����'), ('72', N'������'),
('12', N'�������'), ('40', N'�������'), ('15', N'�����'),
('55', N'������');

GO

INSERT INTO [dbo].[Bank_Clients] 
VALUES
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'�����' 
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients))
	,N'Test Testov', N'street Testovaya 21', '123214213247', '1999-01-10 00:00:00' 
),
(
	(SELECT TOP 1  Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1  Id FROM [dbo].[Countries] WHERE Name = N'���������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '523212213242', '1990-03-07 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'���������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 2', '623211213241', '1995-05-06 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients )), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'��������������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 4', '823215213242', '1989-07-04 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'��������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 6', '223218213244', '1979-02-25 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�����'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 4', '423217213246', '1976-02-14 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'��������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 3', '123215213245', '1991-05-19 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'����-����'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 2', '123214213244', '1975-04-10 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '523213213243', '1983-06-23 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'�������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'������'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 23', '423218213241', '1982-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'�������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�����'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 321', '425788212841', '1980-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'�����'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�����'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 53', '351210213241', '1999-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'������'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'�����'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '923218213321', '1976-12-20 00:00:00' 
);