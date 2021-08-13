SELECT

(SELECT Name FROM Cities WHERE CityId = Id) AS ClientCity, 

(SELECT Name FROM Countries WHERE CountryId = Id) AS ClientCountry,

COUNT('result') AS [Count]

FROM dbo.Bank_Clients

GROUP BY CityId, CountryId

ORDER BY ClientCountry, ClientCity;
