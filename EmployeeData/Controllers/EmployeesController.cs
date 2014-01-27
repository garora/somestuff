using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeData.Models;

namespace EmployeeData.Controllers
{
    public class EmployeesController : ApiController
    {
        //initialization of our repository is not suited as a best programming/design approach
        //We might need some kind of DI to make it more reliable and durable. Reliable: we should 
        //initialize any type IEmployeeRepository and durable as we now what we are implementing :)

        static readonly IEmployeeRepository repository = new EmployeeRepository();

        //instead of above we could do like this 

        //Todo- uncomment if implemented Dependency injection

        //readonly EmployeeData.Models.IEmployeeRepository _repository;

        //public EmployeesController(EmployeeData.Models.IEmployeeRepository repository)
        //{
        //    _repository = repository;
        //}


        //Todo- need to check if there is mandatory to add GET, POST, PUT prefixes to method names

        //uri=/api/employees
        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }

        //uri=/api/employees/id
        public Employee GetEmployee(int id)
        {
            var employee = repository.Get(id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

        //uri=/api/employees?departmentName=departmentname
        public IEnumerable<Employee> GetEmployeeBy(string departmentName)
        {
            return repository.GetAll().Where(d => d.DepartmentName == departmentName);
        }

        //uri=/api/employees
        public HttpResponseMessage PostEmployee(Employee employee)
        {
            employee = repository.Add(employee);

            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);

            var uri = Url.Link("DefaultApi", new { id = employee.Id });

            response.Headers.Location = new Uri(uri);

            return response;
        }

        //uri=api/employees/id
        public void PutEmployee(int id, Employee employee)
        {
            employee.Id = id;
            if (!repository.Update(employee))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        //uri=/api/employees/id
        public void DeleteEmployee(int id)
        {
            var employee = repository.Get(id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }

    }
}
