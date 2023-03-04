using Microsoft.EntityFrameworkCore;
using RepositoryWithUOFDemo.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Infrastructure.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private RepositoryWithUofDemoDbContext _dbcontext{get;set;}
        public GenericRepository(RepositoryWithUofDemoDbContext _context)
        {
            _dbcontext = _context;
            
        }
       

        public IEnumerable<Entity> GetAll()
        {
           return  _dbcontext.Set<Entity>();
        }

        public Entity GetById(int Id)
        {
            var model = Initalize();
            var entity= model.Find(Id);
            if (entity != null)
                return entity;
            else
                return null;
        }

        public bool Delete(Entity entity)
        {
            var model = Initalize();
            model.Remove(entity);
            _dbcontext.SaveChanges();
            return true;
        }

        public Entity Create(Entity entity)
        {
            var model = Initalize();
            model.Add(entity);
            _dbcontext.SaveChanges();
            return entity;
        }

        public Entity Update(Entity entity)
        {
            var model = Initalize();
            model.Update(entity);
            _dbcontext.SaveChanges();
            return entity;
        }

        public   DbSet<Entity> Initalize()
        {
            return _dbcontext.Set<Entity>();
        }

      
    }
}
