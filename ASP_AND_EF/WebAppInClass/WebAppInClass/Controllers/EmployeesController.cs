using WebAppInClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppInClass.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        { 
            IList<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", Position = "Software Engineer", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", Position = "Project Manager", Salary = 75000 },
                new Employee { Id = 3, Name = "Mike Johnson", Position = "QA Analyst", Salary = 50000 }
            };
            return View(employees);
        }
    }
}
