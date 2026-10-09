using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAppInClass.Data;

namespace WebAppInClass.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;

            EmployeeRepository = new EmployeeRepository(_db);
            ManagerRepository = new ManagerRepository(_db);
            DepartmentRepository = new DepartmentRepository(_db);


        }

        public IEmployeeRepository EmployeeRepository { get;  }
        public IManagerRepository ManagerRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
    }
}
