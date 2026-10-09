namespace WebAppInClass.Repositories.Base
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        IManagerRepository ManagerRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }

    }
}
