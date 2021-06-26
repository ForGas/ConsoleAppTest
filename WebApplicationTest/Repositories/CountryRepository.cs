using ConsoleAppTest.Data;
using ConsoleAppTest.Data.Model;

namespace WebApplicationTest.Repositories
{
    public class CountryRepository : BaseRepository<Country>
    {
        public CountryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
