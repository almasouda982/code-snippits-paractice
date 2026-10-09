using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppInClass.Dtos;
using WebAppInClass.Services.Base;

namespace WebAppInClass.Controllers
{
    public class ManagersController : Controller
    {
        private readonly IManagerService _managerService;

        public ManagersController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        public async Task<IActionResult> Index()
        {
            var manager = await _managerService.GetAllManagers();

            return View(manager);
        }

        public async Task<IActionResult> Create()
        {
            await LoadDepartmentsAsync();

            return View(new ManagerCreateDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ManagerCreateDto managerDTO)
        {
            if (ModelState.IsValid)
            {
                await _managerService.AddManager(managerDTO);

                return RedirectToAction(nameof(Index));
            }

            await LoadDepartmentsAsync();

            return View(managerDTO);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager = await _managerService.GetManagerById(id.Value);

            if (manager == null)
            {
                return NotFound();
            }

            await LoadDepartmentsAsync();

            return View(manager);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ManagerUpdateDto managerDTO)
        {
            if (ModelState.IsValid)
            {
                var existingManager =
                    await _managerService.GetManagerById(managerDTO.Id);

                if (existingManager == null)
                {
                    return NotFound();
                }

                await _managerService.UpdateManager(managerDTO);

                return RedirectToAction(nameof(Index));
            }

            await LoadDepartmentsAsync();

            return View(managerDTO);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager = await _managerService.GetManagerById(id.Value);

            if (manager == null)
            {
                return NotFound();
            }

            return View(manager);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager = await _managerService.GetManagerById(id.Value);

            if (manager == null)
            {
                return NotFound();
            }

            await _managerService.DeleteManager(id.Value);

            return RedirectToAction(nameof(Index));
        }

        private async Task LoadDepartmentsAsync()
        {
            var departments = await _managerService.GetAllDepartments();

            ViewBag.Departments = new SelectList(
                departments,
                "Id",
                "Name"
            );
        }
    }
}
