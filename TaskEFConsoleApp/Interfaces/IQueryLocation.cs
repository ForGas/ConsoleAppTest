using TaskEFConsoleApp.Data.Model;

namespace TaskEFConsoleApp.Interfaces
{
    public interface IQueryLocation<TCountry, TCity> : IQueryCity<string>, IQueryCountry<string>
        where TCountry : Country
        where TCity : City
    {
        public void Insert(string countryName, string countryCode, string cityName, string cityCode);
        public void Insert(TCity country, TCountry city);
    }
}
