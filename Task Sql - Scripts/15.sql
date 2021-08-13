SELECT T.Sum, T.Operation, City.Name AS [City from], Country.Name AS [Country from],
City.Name AS [City to], Country.Name AS [Country to]
FROM 
Account_Transactions AS T

JOIN Cities AS CityFrom 
ON T.SenderClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE CityFrom.Id = CityId)

JOIN Countries AS CountryFrom
ON T.SenderClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE CountryFrom.Id = CountryId)

JOIN Cities AS City 
ON T.RecipientClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE City.Id = CityId)

JOIN Countries AS Country
ON T.RecipientClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE Country.Id = CountryId)

ORDER BY T.Sum DESC

GO

SELECT T.Sum, T.Operation, City.Name AS [City], Country.Name AS [Country]
FROM 
Account_Transactions AS T

JOIN Cities AS City
ON T.SenderClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE City.Id = CityId)

JOIN Countries AS Country
ON T.SenderClientId = (SELECT TOP 1 Id FROM Bank_Clients WHERE Country.Id = CountryId)

WHERE T.Operation != 'Transfer'
ORDER BY T.Sum DESC