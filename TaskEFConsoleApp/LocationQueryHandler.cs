using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;
using TaskEFConsoleApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace TaskEFConsoleApp
{
    public class LocationQueryHandler : IQueryLocation<Country, City>
    {
        private ApplicationDbContext _context;

        public LocationQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertCity(string cityName, string cityCode)
        {
            try
            {
                if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(cityCode))
                {
                    throw new ArgumentException($"{nameof(cityName)} {nameof(cityCode)}");
                }
                _context.Database.ExecuteSqlRaw("INSERT INTO Cities (Name, Code) VALUES ({0}, {1})", cityName, cityCode);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void InsertCountry(string countryName, string countryCode)
        {
            try
            {
                if (string.IsNullOrEmpty(countryName) || string.IsNullOrEmpty(countryCode))
                {
                    throw new ArgumentException($"{nameof(countryName)} {nameof(countryCode)}");
                }
                _context.Database.ExecuteSqlRaw("INSERT INTO Countries (Name, Code) VALUES ({0}, {1})", countryName, countryCode);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void Insert(City country, Country city)
        {
            try
            {
                if (country is null || city is null)
                {
                    throw new ArgumentNullException($"{nameof(country)} {nameof(city)} is null");
                }

                _context.Database.ExecuteSqlRaw("INSERT INTO Cities (Name, Code) VALUES ({0}, {1})", city.Name, city.Code);
                _context.Database.ExecuteSqlRaw("INSERT INTO Countries (Name, Code) VALUES ({0}, {1})", country.Name, country.Code);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void Insert(string countryName, string countryCode, string cityName, string cityCode)
        {
            try
            {
                if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(cityCode)
                    || string.IsNullOrEmpty(countryName) || string.IsNullOrEmpty(countryCode))
                {
                    throw new ArgumentException("Arguments is null or empty");
                }

                _context.Database.ExecuteSqlRaw("INSERT INTO Cities (Name, Code) VALUES ({0}, {1})", cityName, cityCode);
                _context.Database.ExecuteSqlRaw("INSERT INTO Countries (Name, Code) VALUES ({0}, {1})", countryName, countryCode);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
