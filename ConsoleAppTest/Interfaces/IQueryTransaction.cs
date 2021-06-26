namespace ConsoleAppTest.Interfaces
{
    public interface IQueryTransaction : IQuery
    {
        public void Transfer();
        public void Withdraw();
        public void Put();
    }
}
