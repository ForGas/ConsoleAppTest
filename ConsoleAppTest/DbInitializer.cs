using System;
using System.Linq;
using ConsoleAppTest.Data;
using System.Threading.Tasks;
using ConsoleAppTest.Data.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DbInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task InitializeAsync()
        {
            if (_dbContext.Database.CanConnect() is false)
            {
                await _dbContext.Database.MigrateAsync();
                Seed();
            }
            else
            {
                await _dbContext.Database.MigrateAsync();
            }
        }

        private void Seed()
        {
            CreateDefaultCity();
            CreateDefaultCountry();
            CreateDefaultBankClients();
        }

        private void CreateDefaultCity()
        {
            var cities = new List<City>()
            {
                new City() { Name = "Astana", Code = "123"},
                new City() { Name = "Karaganda", Code = "321"},
                new City() { Name = "Almaty", Code = "456"},
            };

            _dbContext.Cities.AddRange(cities);
            _dbContext.SaveChanges();
        }

        private void CreateDefaultCountry()
        {
            var countries = new List<Country>()
            {
                new Country() { Name = "Kazakhstan", Code = "11"},
                new Country() { Name = "Kazakhstan", Code = "11"},
                new Country() { Name = "Kazakhstan", Code = "11"},
            };

            _dbContext.Countries.AddRange(countries);
            _dbContext.SaveChanges();
        }

        private void CreateDefaultBankClients()
        {
            var clients = new List<BankClient>()
            {
                new BankClient()
                {
                    Address = "Тестовая 1",
                    Iin = "123214213247",
                    FullName = "Dana Amalia",
                    DateOfBirth = new DateTime(1999, 5, 20),
                    Account = new Account() { Number = "56743257", Balance = 10000},
                    City = _dbContext
                                    .Cities
                                    .Where(x => (x.Name == "Astana") && (x.Code == "123")).First(),
                    Country = _dbContext
                                    .Countries
                                    .SingleOrDefault(country => (country.Name == "Kazakhstan") && (country.Id == 1))
                },
                new BankClient()
                {
                    Address = "Тестовая 2",
                    Iin = "523212213242",
                    FullName =
                    "Ingolf Urias",
                    DateOfBirth = new DateTime(1999, 5, 20),
                    Account = new Account() { Number = "32132145", Balance = 10000},
                    City = _dbContext
                                    .Cities
                                    .Where(x => x.Name == "Karaganda" && x.Code == "321").First(),
                    Country = _dbContext
                                    .Countries
                                    .SingleOrDefault(country => (country.Name == "Kazakhstan") && (country.Id == 2))
                },
                new BankClient()
                {
                    Address = "Тестовая 3",
                    Iin = "623211213241",
                    FullName = "Udo Melanija",
                    DateOfBirth = new DateTime(1999, 5, 20),
                    Account = new Account() { Number = "8942576", Balance = 10000},
                    City = _dbContext
                                    .Cities
                                    .Where(x => x.Name == "Almaty" && x.Code == "456").First(),
                    Country = _dbContext
                                    .Countries
                                    .SingleOrDefault(country => (country.Name == "Kazakhstan") && (country.Id == 3))
                },
            };

            _dbContext.BankClients.AddRange(clients);
            _dbContext.SaveChanges();
        }
    }
}
