using Microsoft.EntityFrameworkCore;
using WebAppInClass.Data;
using WebAppInClass.Dtos;
using WebAppInClass.Models;

namespace WebAppInClass.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly AppDbContext _db;
        public ManagerRepository(AppDbContext context)
        {
            _db = context;
        }
        public async Task<IEnumerable<ManagerDto>> GetAllManagersAsync()
        {
            return await _db.Managers
                    .AsNoTracking()
                    .Select(m => new ManagerDto
                    {
                        Id = m.Id,
                        Name = m.Name,
                        Position = m.Position,
                        Salary = m.Salary,
                        DepartmentName = m.Department != null
                            ? m.Department.Name
                            : null
                    })
                    .ToListAsync();
        }
        public async Task<Manager?> GetManagerByIdAsync(int id)
        {
            return await _db.Managers.FindAsync(id);
        }

        public async Task AddManagerAsync(Manager manager)
        {
            await _db.Managers.AddAsync(manager);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateManagerAsync(Manager manager)
        {
            _db.Managers.Update(manager);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteManagerAsync(int id)
        {
            var manager = await _db.Managers.FindAsync(id);

            if (manager != null)
            {
                _db.Managers.Remove(manager);
                await _db.SaveChangesAsync();
            }
        }

        //Task<IEnumerable<EmployeeDto>> IManagerRepository.GetAllManagersAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Employee?> IManagerRepository.GetManagerByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateManagerAsync(Manager manager)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
