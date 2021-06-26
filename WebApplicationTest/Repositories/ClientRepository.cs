using ConsoleAppTest.Data;
using ConsoleAppTest.Data.Model;

namespace WebApplicationTest.Repositories
{
    public class ClientRepository : BaseRepository<BankClient>
    {
        public ClientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
