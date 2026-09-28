namespace MyApp.Core
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployModel>> GetEmployeeDetail();
    }
}