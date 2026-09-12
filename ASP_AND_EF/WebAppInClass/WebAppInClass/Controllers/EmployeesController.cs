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

        //======
        // Create
        //======

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please correct the errors and try again.");
                return View(employee);
            }
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
        }

        //======
        // Edit
        //======
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var emp = _db.Employees.Find(Id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please correct the errors and try again.");
            return View(employee);
        }

        //==========
        // Delete
        //==========
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var emp = _db.Employees.Find(Id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {

            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");


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
