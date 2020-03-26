using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
    public interface IDepartmentRepo
    {
        Department GetDepartment(int id);
        IEnumerable<Department> GetlistDepartment();

    }

}
