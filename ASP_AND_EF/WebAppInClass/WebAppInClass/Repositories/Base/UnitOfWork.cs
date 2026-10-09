using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAppInClass.Data;

namespace WebAppInClass.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext _db)
        {
            EmployeeRepository = new EmployeeRepository(_db);
            
        }

        public IEmployeeRepository EmployeeRepository { get;  }

    }
}
