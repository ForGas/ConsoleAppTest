using System;
using System.Reflection;
using TaskEFConsoleApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace TaskEFConsoleApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankClient> BankClients { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<AccountCityGroup> BalanceByCity { get; set; }
        public DbSet<BankDataGroup> BankData { get; set; }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=852123;database=testDb;",
                new MySqlServerVersion(new Version(8, 0, 25))
            );
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
