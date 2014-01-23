using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int empId);
        Employee Add(Employee employee);
        void Remove(int empId);
        bool Update(Employee employee);
    }
}
