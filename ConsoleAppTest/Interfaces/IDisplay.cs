using ConsoleAppTest.Data.Model;
using System.Collections.Generic;

namespace ConsoleAppTest.Interfaces
{
    public interface IDisplay
    {
        public void Print(ICollection<Account> accounts);
        public void Print(ICollection<BankClient> clients);
        public void Print(ICollection<City> cities);
        public void Print(ICollection<Country> countries);
        public void Print(ICollection<AccountTransaction> transactions);
    }
}
