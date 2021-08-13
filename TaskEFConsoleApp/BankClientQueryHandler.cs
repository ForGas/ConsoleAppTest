using System;
using System.Linq;
using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;
using TaskEFConsoleApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TaskEFConsoleApp
{
    public class BankClientQueryHandler : IQueryClient<BankClient>
    {
        private ApplicationDbContext _context;
        private DbSet<BankClient> _dbSet;

        public BankClientQueryHandler(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<BankClient>();
        }
        public void Insert(BankClient client)
        {
            _context.Database.ExecuteSqlRaw(
                "INSERT INTO Bank_Clients (Address, FullName, Iin, DateOfBirth) VALUES ({0} {1} {2} {3}",
                client.Address, client.FullName, client.Iin, client.DateOfBirth
            );
        }

        public BankClient Save(BankClient client)
        {
            if (client.Id > 0)
            {
                _dbSet.Update(client);
            }
            else
            {
                _dbSet.Add(client);
            }

            _context.SaveChanges();

            return client;
        }

        public bool Delete(BankClient client)
        {
            try
            {
                _dbSet.Remove(client);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");

                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                _context.Database.ExecuteSqlInterpolated($"DELETE Bank_Clients WHERE Id = {id}");
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");

                return false;
            }
        }

        public bool Delete(string iin)
        {
            try
            {
                int numbers = 0;

                if (string.IsNullOrEmpty(iin) || iin.Length is not 12 
                    || int.TryParse(iin, out numbers) is false)
                {
                    throw new ArgumentException($"{nameof(iin)} is null or empty or iin is not digits {numbers}");
                }

                _context.Database.ExecuteSqlInterpolated($"DELETE Bank_Clients WHERE Iin = {iin}");
                
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");

                return false;
            }
        }

        public void Update(BankClient client)
        {
            try
            {
                var model = _dbSet.SingleOrDefault(x => x.Id == client.Id);

                if (model != default)
                {
                    _context.Database.ExecuteSqlRaw(
                        "UPDATE Bank_Clients " +
                        "SET Iin = {1}, Address = {2}, FullName = {3}, " +
                        "DateOfBirth = {4}, CityId = {5}, CountryId = {6} WHERE Id = {0}",
                        client.Id, client.Iin, client.Address, client.FullName,
                        client.DateOfBirth, client.CityId, client.CountryId);
                }
                else
                {
                    throw new InvalidOperationException(nameof(model));
                }
            }
            catch (InvalidOperationException ex)
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
