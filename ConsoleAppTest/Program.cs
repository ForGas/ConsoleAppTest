using System;
using ConsoleAppTest.Data;
using System.Threading.Tasks;
using ConsoleAppTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using ConsoleAppTest.Data.Model.Base;

namespace ConsoleAppTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var dbContext = new ApplicationDbContext();

            var dbInitializer = new DbInitializer(dbContext);

            await dbInitializer.InitializeAsync();

            var locationHandler = new LocationQueryHandler(dbContext);

            var displayaHandler = new DisplayQueryHandler(dbContext, new DisplayConsole());


            displayaHandler.ShowData();

            Console.ReadLine();
        }

        public static void Transaction(ApplicationDbContext dbContext, string countryName, string countryCode)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            try
            {
                dbContext.Database.ExecuteSqlInterpolated($"INSERT INTO Countries (Name) (Code) VALUES ({countryName}, {countryCode})");

                dbContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
