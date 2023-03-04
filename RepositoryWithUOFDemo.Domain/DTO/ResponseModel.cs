using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Domain.DTO
{
    public  class ResponseModel<T> where T:class
    {
        public bool isSucess { get; set; }
        
        public List<T> Data { get; set; }
       
    }
}
