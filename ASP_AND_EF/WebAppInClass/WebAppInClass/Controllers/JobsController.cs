using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppInClass.Data;
using WebAppInClass.Dtos;
using WebAppInClass.Models;

namespace WebAppInClass.Controllers
{
    //[Authorize]
    public class JobsController : Controller
    {
        //DI
        private readonly AppDbContext _db;

        public JobsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<JobsDto> jobs = _db.Jobs.Select(j => new JobsDto
            {
                Id = j.Id,
                Title = j.Title,
                EmployeeName = j.Employee != null ? j.Employee.Name : null,
                DepartmentName = j.Employee != null && j.Employee.Department != null ? j.Employee.Department.Name : null

            }).ToList();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadEmployees();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                _db.Jobs.Add(job);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            LoadEmployees();
            return View(job);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoadEmployees();
            var job = _db.Jobs.Find(id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }
        [HttpPost]
        public IActionResult Edit(JobsUpdateDto jobDTO)
        {
            if (ModelState.IsValid)
            {
                var job = _db.Jobs.Find(jobDTO.Id);
                if (job == null)
                {
                    return NotFound();
                }
                job.Title = jobDTO.Title;
                job.EmployeeId = (int)jobDTO.EmployeeId;

            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            LoadEmployees();
            return View(jobDTO);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            LoadEmployees();
            var job = _db.Jobs.Find(id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        [HttpPost]
        public ActionResult Delete(Job job)
        {
            _db.Jobs.Remove(job);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        private void LoadEmployees()
        {
            var employees = _db.Employees.ToList();
            ViewBag.Employees = new SelectList(employees, "Id", "Name");
            var departments = _db.Departments.ToList();
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
        }
    }
}
