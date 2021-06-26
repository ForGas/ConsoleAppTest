using System.Linq;
using ConsoleAppTest.Data;
using System.Collections.Generic;
using ConsoleAppTest.Data.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Repositories
{
    public abstract class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : BaseModel
    {
        protected ApplicationDbContext _dbContext;
        protected DbSet<Entity> _dbSet;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Entity>();
        }

        public Entity Get(long id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public ICollection<Entity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Remove(Entity model)
        {
            _dbSet.Remove(model);
            _dbContext.SaveChanges();
        }

        public Entity Save(Entity model)
        {
            if (model.Id > 0)
            {
                _dbSet.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }

            _dbContext.SaveChanges();

            return model;
        }
    }
}
