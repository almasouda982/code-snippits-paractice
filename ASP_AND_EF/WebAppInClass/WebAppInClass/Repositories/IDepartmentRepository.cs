
using WebAppInClass.Models;

namespace WebAppInClass.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    }
}
