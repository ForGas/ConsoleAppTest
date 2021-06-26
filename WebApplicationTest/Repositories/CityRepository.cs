using ConsoleAppTest.Data;
using ConsoleAppTest.Data.Model;

namespace WebApplicationTest.Repositories
{
    public class CityRepository : BaseRepository<City>
    {
        public CityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
