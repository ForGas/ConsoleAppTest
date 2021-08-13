using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;

namespace TaskWebApp.Repositories
{
    public class ClientRepository : BaseRepository<BankClient>
    {
        public ClientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
