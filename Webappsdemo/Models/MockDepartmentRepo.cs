using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webappsdemo.Models;

namespace Webappsdemo.Models
{
    public class MockDepartmentRepo:IDepartmentRepo
    {
        public List<Department> _departments;
        public MockDepartmentRepo()
        {
            _departments = new List<Department>()
           {
               new Department(){DepartmentId=1,DepartmentName="Sales"},
               new Department(){DepartmentId=2,DepartmentName="Finance"},
               new Department(){DepartmentId=3,DepartmentName="Operation"},
               new Department(){DepartmentId=4,DepartmentName="Admin"},
               new Department(){DepartmentId=5,DepartmentName="IT"},
               new Department(){DepartmentId=6,DepartmentName="Marketing"}
              
           };
        }

        public Department GetDepartment(int id)
        {
            return (_departments.FirstOrDefault(obj => obj.DepartmentId == id));
        }

        //public Department GetDepartment()
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Department> GetlistDepartment()
        {
            return (_departments);
        }
    }
}
