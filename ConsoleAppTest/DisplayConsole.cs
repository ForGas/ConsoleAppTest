using System;
using System.Linq;
using ConsoleAppTest.Data.Model;
using System.Collections.Generic;
using ConsoleAppTest.Interfaces;

namespace ConsoleAppTest
{
    public class DisplayConsole : IDisplay
    {
        public void Print(ICollection<AccountCityGroup> group)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tBalance by City and Country:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = group.AsQueryable().ElementType.GetProperties().ToList();
            var entities = group.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<BankDataGroup> group)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tBalance by City and Country:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = group.AsQueryable().ElementType.GetProperties().ToList();
            var entities = group.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {

                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }


        public void Print(ICollection<Account> accounts)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tAccounts TABLE:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = accounts.AsQueryable().ElementType.GetProperties().ToList();
            var entities = accounts.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<BankClient> clients)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tBank_Clients TABLE:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = clients.AsQueryable().ElementType.GetProperties().ToList();
            var entities = clients.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)} ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<City> cities)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tCities TABLE:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = cities.AsQueryable().ElementType.GetProperties().ToList();
            var entities = cities.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<Country> countries)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tCountries TABLE:");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = countries.AsQueryable().ElementType.GetProperties().ToList();
            var entities = countries.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<AccountTransaction> transactions)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tAccount_Transactions TABLE:");
            Console.ForegroundColor = ConsoleColor.Blue;


            var properties = transactions.AsQueryable().ElementType.GetProperties().ToList();
            var entities = transactions.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }
    }
}
