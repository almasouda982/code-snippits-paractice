using WebAppInClass.Dtos;
using WebAppInClass.Models;

namespace WebAppInClass.Services.Base
{
    public interface IManagerService
    {
        Task<IEnumerable<ManagerDto>> GetAllManagers();

        Task<ManagerUpdateDto?> GetManagerById(int id);

        Task<IEnumerable<Department>> GetAllDepartments();

        Task AddManager(ManagerCreateDto managerDTO);

        Task UpdateManager(ManagerUpdateDto managerDTO);

        Task DeleteManager(int id);
    }
}
