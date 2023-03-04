using Microsoft.EntityFrameworkCore;
using RepositoryWithUOFDemo.Domain.Model;
using RepositoryWithUOFDemo.Infrastructure.DBContext;
using RepositoryWithUOFDemo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Infrastructure.UOW
{
    public interface IUnitOfWork:IDisposable
    {


        public IGenericRepository<Employee> Employees { get;}
        public IGenericRepository<Department> Departments { get;}
        public int Save();
        


    }
}
