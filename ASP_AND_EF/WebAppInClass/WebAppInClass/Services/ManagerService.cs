using WebAppInClass.Dtos;
using WebAppInClass.Models;
using WebAppInClass.Repositories.Base;
using WebAppInClass.Services.Base;

namespace WebAppInClass.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<ManagerDto>> GetAllManagers()
        {
            return await _unitOfWork.ManagerRepository
                .GetAllManagersAsync();
        }

        public async Task<ManagerUpdateDto?> GetManagerById(int id)
        {
            var manager = await _unitOfWork.ManagerRepository
                .GetManagerByIdAsync(id);

            if (manager == null)
            {
                return null;
            }

            return new ManagerUpdateDto
            {
                Id = manager.Id,
                Name = manager.Name,
                Email = manager.Email,
                Position = manager.Position,
                Salary = manager.Salary,
                DepartmentId = manager.DepartmentId
            };
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _unitOfWork.DepartmentRepository
                .GetAllDepartmentsAsync();
        }

        public async Task AddManager(ManagerCreateDto managerDTO)
        {
            var manager = new Manager
            {
                Name = managerDTO.Name,
                Email = managerDTO.Email,
                Position = managerDTO.Position,
                Salary = managerDTO.Salary,
                DepartmentId = managerDTO.DepartmentId
            };

            await _unitOfWork.ManagerRepository
                .AddManagerAsync(manager);
        }

        public async Task UpdateManager(ManagerUpdateDto managerDTO)
        {
            var manager = await _unitOfWork.ManagerRepository
                .GetManagerByIdAsync(managerDTO.Id);

            if (manager == null)
            {
                throw new KeyNotFoundException("Manager not found");
            }

            manager.Name = managerDTO.Name;
            manager.Email = managerDTO.Email;
            manager.Position = managerDTO.Position;
            manager.Salary = managerDTO.Salary;
            manager.DepartmentId = managerDTO.DepartmentId;

            await _unitOfWork.ManagerRepository
                .UpdateManagerAsync(manager);
        }

        public async Task DeleteManager(int id)
        {
            var manager = await _unitOfWork.ManagerRepository
                .GetManagerByIdAsync(id);

            if (manager == null)
            {
                throw new KeyNotFoundException("Manager not found");
            }

            await _unitOfWork.ManagerRepository
                .DeleteManagerAsync(id);
        }
    }
}
