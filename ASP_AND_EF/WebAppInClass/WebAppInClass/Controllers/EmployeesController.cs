using WebAppInClass.Models;
using Microsoft.AspNetCore.Mvc;
using WebAppInClass.Data;

namespace WebAppInClass.Controllers
{
    public class EmployeesController : Controller
    {
        // DI
        private readonly AppDbContext _db;

        public EmployeesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        { 
            IEnumerable<Employee> employees = _db.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        //public IActionResult Index()
        //{ 
        //    IList<Employee> employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "John Doe", Position = "Software Engineer", Salary = 60000 },
        //        new Employee { Id = 2, Name = "Jane Smith", Position = "Project Manager", Salary = 75000 },
        //        new Employee { Id = 3, Name = "Mike Johnson", Position = "QA Analyst", Salary = 50000 }
        //    };
        //    return View(employees);
        //}
    }
}
