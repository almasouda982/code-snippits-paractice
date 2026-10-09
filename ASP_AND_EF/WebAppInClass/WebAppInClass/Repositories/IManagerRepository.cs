using WebAppInClass.Dtos;
using WebAppInClass.Models;

namespace WebAppInClass.Repositories
{
    public interface IManagerRepository
    {
        Task<IEnumerable<ManagerDto>> GetAllManagersAsync();

        Task<Manager?> GetManagerByIdAsync(int id);

        Task AddManagerAsync(Manager manager);

        Task UpdateManagerAsync(Manager manager);

        Task DeleteManagerAsync(int id);
    }
}
