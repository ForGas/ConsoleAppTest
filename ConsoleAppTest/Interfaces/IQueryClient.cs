using ConsoleAppTest.Data.Model;

namespace ConsoleAppTest.Interfaces
{
    public interface IQueryClient<Entity> : IQuery 
        where Entity : BankClient
    {
        public void Insert(Entity client);
        public Entity Save(Entity client);
        public bool Delete(Entity client);
        public bool Delete(long id);
        public bool Delete(string iin);
        public void Update(BankClient client);
    }
}
