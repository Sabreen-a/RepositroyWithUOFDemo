using Microsoft.EntityFrameworkCore;
using RepositoryWithUOFDemo.Domain.Model;
using RepositoryWithUOFDemo.Infrastructure.DBContext;
using RepositoryWithUOFDemo.Infrastructure.Repositories;
using RepositoryWithUOFDemo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Infrastructure.UOW
{
    public  class UnitOfWork : IUnitOfWork
    {
        private RepositoryWithUofDemoDbContext _dbcontext;
        
        public  IGenericRepository<Employee> Employees { get; set; }
        public IGenericRepository<Department> Departments { get; set ; }

        public UnitOfWork(RepositoryWithUofDemoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            Employees = new GenericRepository<Employee>(_dbcontext);
            Departments = new GenericRepository<Department>(_dbcontext);
        }

       

        public void   Dispose()
        {
            _dbcontext.Dispose();
        }

        public int Save()
        {
            return _dbcontext.SaveChanges();
        }
    }
}
