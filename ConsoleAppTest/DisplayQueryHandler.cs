using System.Linq;
using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;
using TaskEFConsoleApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TaskEFConsoleApp
{
    public class DisplayQueryHandler : IQuerySelect
    {
        private readonly ApplicationDbContext _context;
        private readonly IDisplay _display;

        public DisplayQueryHandler(ApplicationDbContext context, IDisplay display)
        {
            _context = context;
            _display = display;
        }

        public void ShowBalanceByCity()
        {

            var accounts = from account in _context.Accounts
                           join city in _context.Cities
                           on account.ClientId equals (from id in _context.BankClients
                                                                .Where(x => x.CityId == city.Id)
                                                                .Select(x => x.Id)
                                                       select id).First()
                           join country in _context.Countries
                           on account.ClientId equals (from id in _context.BankClients
                                                               .Where(x => x.CountryId == country.Id)
                                                               .Select(x => x.Id)
                                                       select id).First()
                           group account by new 
                           { 
                               cityName = city.Name,
                               countryName = country.Name,
                           } into balanceByCityGroup
                           select new AccountCityGroup
                           {
                               TotalSum = balanceByCityGroup.Sum(x => x.Balance),
                               Country = balanceByCityGroup.Key.cityName,
                               City = balanceByCityGroup.Key.countryName
                           };

            _display.Print(accounts.ToList());
        }

        public void ShowBalanceByCityViaView()
        {

            _context.Database.ExecuteSqlRaw(@"CREATE OR REPLACE VIEW View_BalanceByCity AS
                            SELECT Sum(Balance) AS TotalSum, Cities.Name AS City, Countries.Name AS Country
                            FROM Accounts
                            INNER JOIN Cities 
                            ON ClientId = (select Id FROM bank_clients where CityId = Cities.Id limit 1)
                            INNER JOIN Countries 
                            ON ClientId = (select Id FROM bank_clients where CountryId = Countries.Id limit 1)
                            group by Cities.Name");


            var balanceByCityData = _context.BalanceByCity.ToList();

            _display.Print(balanceByCityData);

        }

        public void ShowDataBase()
        {
            var cities = _context.Cities.FromSqlRaw("SELECT * FROM Cities").ToList();
            _display.Print(cities);

            var countries = _context.Countries.FromSqlRaw("SELECT * FROM Countries").ToList();
            _display.Print(countries);

            var clients = _context.BankClients.FromSqlRaw("SELECT * FROM Bank_Clients").ToList();
            _display.Print(clients);

            var accounts = _context.Accounts.FromSqlRaw("SELECT * FROM Accounts").ToList();
            _display.Print(accounts);

            var transactions = _context.AccountTransactions.FromSqlRaw("SELECT * FROM Account_Transactions").ToList();
            _display.Print(transactions);
        }

        public void ShowDataViaView()
        {
            _context.Database.ExecuteSqlRaw(@"CREATE OR REPLACE VIEW View_BankData AS
                                            SELECT Client.FullName As Name, Client.Address, Client.Iin, 
                                            CAST(Client.DateOfBirth AS DATE) AS DateOfBirth, 
                                            City.Name AS City, City.Code AS CityCode,
                                            Country.Name AS Country, Country.Code AS CountryCode,
                                            Account.Balance, Account.Number
                                            FROM bank_clients AS Client
                                            INNER JOIN cities AS City ON
                                            CityId = City.Id
                                            INNER JOIN countries AS Country ON
                                            CountryId = Country.Id
                                            LEFT JOIN accounts AS Account ON
                                            Client.Id = Account.ClientId");

            var data = _context.BankData.ToList();

            _display.Print(data);
        }

        public void ShowData()
        {
            var entities = _context.Model.GetEntityTypes().ToList();

            foreach (var entity in entities)
            {
                string sqlQuery = $"SELECT * FROM {entity.GetTableName()}";

                switch (entity.FullName())
                {
                    case "City":
                        _display.Print(_context.Cities.FromSqlRaw(sqlQuery).AsNoTracking().ToList());
                        break;
                    case "Country":
                        _display.Print(_context.Countries.FromSqlRaw(sqlQuery).AsNoTracking().ToList());
                        break;
                    case "Account":
                        _display.Print(_context.Accounts.FromSqlRaw(sqlQuery).AsNoTracking().ToList());
                        break;
                    case "BankClient":
                        _display.Print(_context.BankClients.FromSqlRaw(sqlQuery).AsNoTracking().ToList());
                        break;
                    case "AccountTransaction":
                        _display.Print(_context.AccountTransactions.FromSqlRaw(sqlQuery).AsNoTracking().ToList());
                        break;
                };
            }
        }
    }
}
