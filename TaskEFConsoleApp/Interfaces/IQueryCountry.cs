namespace TaskEFConsoleApp.Interfaces
{
    public interface IQueryCountry<T> : IQuery
    {
        public void InsertCountry(T countryName, T countryCode);
    }
}
