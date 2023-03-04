using Microsoft.AspNetCore.Mvc;
using RepositoryWithUOFDemo.Domain.Model;
using RepositoryWithUOFDemo.Infrastructure.DBContext;
using RepositoryWithUOFDemo.Infrastructure.Repositories;
using RepositoryWithUOFDemo.Infrastructure.UOW;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepositroyWithUOFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //private IGenericRepository<Employee> _repo { get; set; }
        private IUnitOfWork uow { get; set; }
        public EmployeeController(IUnitOfWork _uow)
        {
            uow = _uow; ;
        }


        
       
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           
            return uow.Employees.GetAll();
        }

        
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return uow.Employees.GetById(id);
        }

       
        [HttpPost]
        public Employee Post(Employee emp)
        {
            return uow.Employees.Create(emp);
        }

       
        [HttpPut]
        public Employee Put(Employee emp)
        {
            return uow.Employees.Update(emp);
        }

       
        [HttpDelete]
        public bool Delete(Employee emp)
        {
            return uow.Employees.Delete(emp);
        }
    }
}
