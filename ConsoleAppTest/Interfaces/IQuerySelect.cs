namespace TaskEFConsoleApp.Interfaces
{
    public interface IQuerySelect : IQuery
    {
        public void ShowData();
        public void ShowDataBase();
        public void ShowDataViaView();
        public void ShowBalanceByCity();
        public void ShowBalanceByCityViaView();
    }
}
