using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeData.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int empId)
        {
            throw new NotImplementedException();
        }

        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Remove(int empId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}