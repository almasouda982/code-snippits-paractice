using Microsoft.EntityFrameworkCore;
using WebAppInClass.Models;

namespace WebAppInClass.Repositories
{
    public interface IEmployeeRepository
    {

        Task<IEnumerable<Employee>> GetAllEmployeeAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);

    }
}
