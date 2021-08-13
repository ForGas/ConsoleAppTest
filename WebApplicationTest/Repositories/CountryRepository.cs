using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;

namespace TaskWebApp.Repositories
{
    public class CountryRepository : BaseRepository<Country>
    {
        public CountryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
