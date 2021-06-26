namespace ConsoleAppTest.Interfaces
{
    public interface IQueryCity<T> : IQuery
    {
        public void InsertCity(T cityName, T cityCode);
    }
}
