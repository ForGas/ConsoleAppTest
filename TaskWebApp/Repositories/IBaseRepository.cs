using TaskEFConsoleApp.Data.Model.Base;
using System.Collections.Generic;

namespace TaskWebApp.Repositories
{
    interface IBaseRepository<Entity> where Entity : BaseModel
    {
        public Entity Get(long id);
        ICollection<Entity> GetAll();
        void Remove(Entity model);
        Entity Save(Entity model);
    }
}
