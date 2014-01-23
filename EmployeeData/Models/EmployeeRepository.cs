using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeData.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees = GetEmployees();
        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Get(int empId)
        {
            return _employees.FirstOrDefault(x => x.Id == empId);
        }

        public Employee Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("employee");
            }

            _employees.Add(employee);

            return employee;
        }

        public void Remove(int empId)
        {
            _employees.RemoveAll(e => e.Id == empId);
        }

        public bool Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("employee");
            }

            var index = _employees.FindIndex(p => p.Id == item.Id);
            
            if (index == -1)
            {
                return false;
            }
            _employees.RemoveAt(index);
            _employees.Add(employee);
            return true;
        }

        private static List<Employee> GetEmployees()
        {
            return new List<Employee>(new[]
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Joseph",
                    MiddleName = "A.",
                    LastName = "Bulger",
                    DepartmentName = "Solutions",
                    Title = "Enteprise Solution Architect"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Shuby",
                    MiddleName = "",
                    LastName = "Arora",
                    DepartmentName = "Research & Development",
                    Title = "Sr. Scientist"
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Gaurav",
                    MiddleName = "Kumar",
                    LastName = "Arora",
                    DepartmentName = "Solutions",
                    Title = "Project Leader"
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Anil",
                    MiddleName = "Kumar",
                    LastName = "Pandey",
                    DepartmentName = "Software",
                    Title = "Technical Leader"
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Ram",
                    MiddleName = "Nath",
                    LastName = "Rao",
                    DepartmentName = "Web Air",
                    Title = "Development Manager"
                }

            });
        }
    }
}