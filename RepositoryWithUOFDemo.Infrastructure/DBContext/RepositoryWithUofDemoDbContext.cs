using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RepositoryWithUOFDemo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Infrastructure.DBContext
{
    public  class RepositoryWithUofDemoDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public RepositoryWithUofDemoDbContext(DbContextOptions<RepositoryWithUofDemoDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Server=.;Database=RepoWithUofDem;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False", 
                    providerOptions => { providerOptions.EnableRetryOnFailure(); });
        }

    }
}
