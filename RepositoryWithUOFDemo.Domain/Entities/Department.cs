using RepositoryWithUOFDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOFDemo.Domain.Model
{
    public  class Department: BaseEntity
    {
        
        public string DeptName { get; set; }
        public Employee Employee { get; set; }
        //public int EmpId { get; set; }
    }
}
