
using WebAppInClass.Data;
using WebAppInClass.Models;
using WebAppInClass.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppInClass.Repositories;

public class CategoriesController : Controller
{
    //private readonly AppDbContext _context;

    //public CategoriesController(AppDbContext context)
    //{
    //    _context = context;
    //}

    private readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    // GET: CATEGORYS
    public async Task<IActionResult> Index()    
    {
        return View(await _categoryRepository.GetAllCategoriesAsync());
       // return View(await _context.Category.ToListAsync());
    }

    // GET: CATEGORYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var category = await _categoryRepository.GetCategoryByIdAsync(id.Value);

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
    public async Task<IActionResult> Create([Bind("Id,Name,Products")] Category category)
    {
        if (ModelState.IsValid)
        {
           await _categoryRepository.AddCategoryAsync(category);

            //_context.Add(category);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }

    // GET: CATEGORYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var category = await _categoryRepository.GetCategoryByIdAsync(id.Value);
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
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Products")] Category category)
    {
        if (id != category.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
               await _categoryRepository.UpdateCategoryAsync(category);

                //_context.Update(category);
                //await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }

    // GET: CATEGORYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var category = await _categoryRepository.GetCategoryByIdAsync(id.Value);
        //var category = await _context.Category
        //    .FirstOrDefaultAsync(m => m.Id == id);
        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }

    // POST: CATEGORYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(id.Value);
        //var category = await _context.Category.FindAsync(id);
        if (category != null)
        {
             await _categoryRepository.DeleteCategoryAsync(category.Id);
            //_context.Category.Remove(category);
        }

        //await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

   
}
