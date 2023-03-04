using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Infrastructure.Repositories
{
    public  interface  IGenericRepository<Entity> where Entity:class
    {
        IEnumerable<Entity> GetAll();

        Entity GetById(int Id);

        bool Delete(Entity ID);

        Entity Create(Entity entity);

        Entity Update(Entity entity);

        DbSet<Entity> Initalize();
    }
}
