namespace WebAppInClass.Repositories.Base
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
