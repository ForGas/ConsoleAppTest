using System.Linq;
using ConsoleAppTest.Data;
using ConsoleAppTest.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
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

        public void ShoDataViaView()
        {
            _context.Database.ExecuteSqlRaw(@"CREATE VIEW View_ShowDataAll AS SELECT");
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
                        _display.Print(_context.Cities.FromSqlRaw(sqlQuery).ToList());
                        break;
                    case "Country":
                        _display.Print(_context.Countries.FromSqlRaw(sqlQuery).ToList());
                        break;
                    case "Account":
                        _display.Print(_context.Accounts.FromSqlRaw(sqlQuery).ToList());
                        break;
                    case "BankClient":
                        _display.Print(_context.BankClients.FromSqlRaw(sqlQuery).ToList());
                        break;
                    case "AccountTransaction":
                        _display.Print(_context.AccountTransactions.FromSqlRaw(sqlQuery).ToList());
                        break;
                };
            }
        }
    }
}
