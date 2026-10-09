using WebAppInClass.Models;
using Microsoft.AspNetCore.Mvc;
using WebAppInClass.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppInClass.Dtos;


namespace WebAppInClass.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        // DI
        private readonly AppDbContext _db;

        public EmployeesController(AppDbContext db)
        {
            _db = db;
        }
        //public IActionResult Index()
        //{ 
        //    IEnumerable<Employee> employees = _db.Employees.ToList();
        //    return View(employees);
        //}

        //public async Task<IActionResult> Index()
        //{
        //    IEnumerable<Employee> employees = await _db.Employees.Include(e=>e.Department).ToListAsync();
        //    return View(employees);
        //}

        public ActionResult Index()
        {
            //Entity Framework Approach

            IEnumerable<EmployeeDto> employees = _db.Employees.Select(e => new EmployeeDto
            {
                //Mapping the properties of Employee to EmployeeDto
                Id = e.Id,
                Name = e.Name,
                Position = e.Position,
                Salary = e.Salary,
                DepartmentName = e.Department != null ? e.Department.Name : null
            }).ToList();

            return View(employees);
        }


        //public ActionResult Index()
        //{
        //    //Entity Framework Approach

        //    IEnumerable<Employee> employees = _db.Employees.Include(e => e.Department).ToList();
        //    return View(employees);
        //}


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            loadDepartments();
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeUpdateDto employeeDTO)
        {
            if (ModelState.IsValid)
            {
                var employee = _db.Employees.Find(employeeDTO.Id);
                if (employee == null)
                {
                    return NotFound();
                }

                //Mapping the properties of EmployeeUpdateDto to Employee
                employee.Name = employeeDTO.Name;
                employee.Position = employeeDTO.Position;
                employee.Salary = employeeDTO.Salary;
                employee.DepartmentId = employeeDTO.DepartmentId;

                //  _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            loadDepartments();
            return View(employeeDTO);

        }


        private void loadDepartments()
        {
            var departments = _db.Departments.ToList();
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
        }


        public ActionResult Create()
        {
            loadDepartments();


            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeCreateDto employeeDTO)
        {
            if (ModelState.IsValid)
            {

                //Mapping the properties of EmployeeCreateDto to Employee
                var employee = new Employee
                {
                    Name = employeeDTO.Name,
                    Position = employeeDTO.Position,
                    Salary = employeeDTO.Salary,
                    DepartmentId = employeeDTO.DepartmentId
                };

                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            loadDepartments();
            return View(employeeDTO);

        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

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
