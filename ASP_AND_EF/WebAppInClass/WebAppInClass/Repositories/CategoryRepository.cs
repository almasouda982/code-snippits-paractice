using WebAppInClass.Data;
using WebAppInClass.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppInClass.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }


        public Task AddCategoryAsync(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChangesAsync();
        }

        public Task DeleteCategoryAsync(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
               return _context.SaveChangesAsync();
            }

            return Task.CompletedTask;
        }
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            return categories;
        }
        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category;


        }
        public Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            return _context.SaveChangesAsync();

        }
    }
}
