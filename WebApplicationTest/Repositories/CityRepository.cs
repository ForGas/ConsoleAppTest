using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;

namespace TaskWebApp.Repositories
{
    public class CityRepository : BaseRepository<City>
    {
        public CityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
