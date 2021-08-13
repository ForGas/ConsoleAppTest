INSERT INTO [dbo].[Countries] VALUES
('895', N'Абхазия'), ('036', N'Австралия'), ('036', N'Австралия'),
('826', N'Великобритания'), ('348', N'Венгрия'), ('332', N'Гаити'),
('276', N'Германия'), ('376', N'Израиль'), ('724', N'Испания'),
('124', N'Канада'), ('404', N'Кения'), ('156', N'Китай'),
('156', N'Китай');

GO

INSERT INTO [dbo].[Cities] VALUES
('1', N'Сухум'), ('21', N'Сидней'), ('21', N'Сидней'),
('32', N'Лондон'), ('31', N'Будапешт'), ('33', N'Дельма'),
('27', N'Берлин'), ('37', N'Тель-Авив'), ('72', N'Мадрид'),
('12', N'Торонто'), ('40', N'Момбаса'), ('15', N'Пекин'),
('55', N'Шанхай');

GO

INSERT INTO [dbo].[Bank_Clients] 
VALUES
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Сухум' 
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Абхазия'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients))
	,N'Test Testov', N'street Testovaya 21', '123214213247', '1999-01-10 00:00:00' 
),
(
	(SELECT TOP 1  Id FROM [dbo].[Cities] WHERE Name = N'Сидней'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1  Id FROM [dbo].[Countries] WHERE Name = N'Австралия'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '523212213242', '1990-03-07 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Сидней'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Австралия'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 2', '623211213241', '1995-05-06 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Лондон'
	AND Id != ALL(SELECT CityId FROM Bank_Clients )), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Великобритания'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 4', '823215213242', '1989-07-04 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Будапешт'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Венгрия'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 6', '223218213244', '1979-02-25 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Дельма'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Гаити'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 4', '423217213246', '1976-02-14 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Берлин'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Германия'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 3', '123215213245', '1991-05-19 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Тель-Авив'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Израиль'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 2', '123214213244', '1975-04-10 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Мадрид'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Испания'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '523213213243', '1983-06-23 00:00:00' 
), 
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Торонто'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Канада'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 23', '423218213241', '1982-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Момбаса'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Кения'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 321', '425788212841', '1980-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Пекин'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Китай'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 53', '351210213241', '1999-12-20 00:00:00' 
),
(
	(SELECT TOP 1 Id FROM [dbo].[Cities] WHERE Name = N'Шанхай'
	AND Id != ALL(SELECT CityId FROM Bank_Clients)), 
	(SELECT TOP 1 Id FROM [dbo].[Countries] WHERE Name = N'Китай'
	AND Id != ALL(SELECT CountryId FROM Bank_Clients)), 
	N'Test Testov', N'street Testovaya 1', '923218213321', '1976-12-20 00:00:00' 
);