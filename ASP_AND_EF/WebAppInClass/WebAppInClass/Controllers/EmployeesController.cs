using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppInClass.Data;
using WebAppInClass.Dtos;
using WebAppInClass.Models;
using WebAppInClass.Repositories;
using WebAppInClass.Repositories.Base;


namespace WebAppInClass.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        // DI

        //private readonly IEmployeeRepository _employeeRepository;

        //public EmployeesController(IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}


        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: CATEGORYS
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.EmployeeRepository.GetAllEmployeeAsync());
            // return View(await _context.Category.ToListAsync());
        }

        // GET: CATEGORYS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _unitOfWork.EmployeeRepository.GetEmployeeByIdAsync(id.Value);

            //var category = await _context.Category
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: CATEGORYS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CATEGORYS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Products")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.EmployeeRepository.AddEmployeeAsync(employee);

                //_context.Add(category);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: CATEGORYS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _unitOfWork.EmployeeRepository.GetEmployeeByIdAsync(id.Value);
            //var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CATEGORYS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Products")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.EmployeeRepository.UpdateEmployeeAsync(employee);

                    //_context.Update(category);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: CATEGORYS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _unitOfWork.EmployeeRepository.GetEmployeeByIdAsync(id.Value);
            //var category = await _context.Category
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: CATEGORYS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var category = await _unitOfWork.EmployeeRepository.GetEmployeeByIdAsync(id.Value);
            //var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                await _unitOfWork.EmployeeRepository.DeleteEmployeeAsync(category.Id);
                //_context.Category.Remove(category);
            }

            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
