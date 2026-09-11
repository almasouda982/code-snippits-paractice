using Microsoft.AspNetCore.Mvc;
using WebAppInClass.Data;
using WebAppInClass.Models;

namespace WebAppInClass.Controllers
{
    public class DepartmentsController : Controller
    {
        // DI
        private readonly AppDbContext _db;

        public DepartmentsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Department> departments = _db.Departments.ToList();
            return View(departments);
        }
    }
}
