using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryWithUOFDemo.Domain.Model;
using RepositoryWithUOFDemo.Infrastructure.Repositories;
using RepositoryWithUOFDemo.Infrastructure.UOW;

namespace RepositroyWithUOFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //private IGenericRepository<Department> _repo { get; set; }
        private IUnitOfWork uow { get; set; }
        public DepartmentController(IUnitOfWork _uow)
        {
            uow = _uow; ;
        }
       
        [HttpGet]
        public IEnumerable<Department> Get()
        {

            return uow.Departments.GetAll();
        }

        
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return uow.Departments.GetById(id);
        }

        
        [HttpPost]
        public Department Post(Department emp)
        {
            return uow.Departments.Create(emp);
        }

        
        [HttpPut]
        public Department Put(Department emp)
        {
            return uow.Departments.Update(emp);
        }

       
        [HttpDelete]
        public bool Delete(Department emp)
        {
            return uow.Departments.Delete(emp);
        }
    }
}
