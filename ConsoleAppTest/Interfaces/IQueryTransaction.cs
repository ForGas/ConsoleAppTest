using ConsoleAppTest.Data.Model;

namespace ConsoleAppTest.Interfaces
{
    public interface IQueryTransaction : IQuery
    {
        public void Transfer(AccountTransaction operation);
        public void Withdraw(AccountTransaction operation);
        public void Put(AccountTransaction operation);
    }
}
