using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;

namespace EmployeeServiceTA.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        // GET: Employee
      public IEnumerable<Employee>Get()
        {
            using(EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}