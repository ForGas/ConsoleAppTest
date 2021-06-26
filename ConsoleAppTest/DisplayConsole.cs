using System;
using System.Linq;
using ConsoleAppTest.Data.Model;
using System.Collections.Generic;
using ConsoleAppTest.Interfaces;

namespace ConsoleAppTest
{
    public class DisplayConsole : IDisplay
    {
        public void Print(ICollection<Account> accounts)
        {
            Console.WriteLine("Accounts TABLE:");

            var properties = accounts.AsQueryable().ElementType.GetProperties().ToList();
            var entities = accounts.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.Write($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<BankClient> clients)
        {
            Console.WriteLine("Bank_Clients TABLE:");

            var properties = clients.AsQueryable().ElementType.GetProperties().ToList();
            var entities = clients.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.Write($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)} ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<City> cities)
        {
            Console.WriteLine("Cities TABLE:");

            var properties = cities.AsQueryable().ElementType.GetProperties().ToList();
            var entities = cities.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.Write($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<Country> countries)
        {
            Console.WriteLine("Countries TABLE:");

            var properties = countries.AsQueryable().ElementType.GetProperties().ToList();
            var entities = countries.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.Write($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }

        public void Print(ICollection<AccountTransaction> transactions)
        {
            Console.WriteLine("Account_Transactions TABLE:");

            Console.WriteLine("Countries TABLE:");

            var properties = transactions.AsQueryable().ElementType.GetProperties().ToList();
            var entities = transactions.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.Write($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }
    }
}
