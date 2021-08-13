CREATE OR REPLACE VIEW View_BalanceByCity AS 
SELECT Sum(Balance) AS TotalSum, cities.Name AS City, countries.Name AS Country
FROM testdb.accounts
INNER JOIN testdb.cities ON ClientId = (select Id FROM testdb.bank_clients where CityId = cities.Id limit 1)
INNER JOIN testdb.countries ON ClientId = (select Id FROM testdb.bank_clients where CountryId = countries.Id limit 1)
group by cities.Name