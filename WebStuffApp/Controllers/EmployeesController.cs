using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebStuffApp.Models;

namespace WebStuffApp.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEnumerable<Employee> _employees = GetEmployees();
        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        public IHttpActionResult GetBy(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);

            return employee == null ? (IHttpActionResult) NotFound() : Ok(employee);
        }

        private static IEnumerable<Employee> GetEmployees()
        {
            return new[]
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
                    Id = 1,
                    FirstName = "Shuby",
                    LastName = "Arora",
                    DepartmentName = "Research & Development",
                    Title = "Sr. Scientist"
                },
                new Employee
                {
                    Id = 1,
                    FirstName = "Gaurav",
                    MiddleName = "Kumar",
                    LastName = "Arora",
                    DepartmentName = "Solutions",
                    Title = "Project Leader"
                }

            };
        }
    }
}
