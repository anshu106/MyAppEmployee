namespace MyApp.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeRepository _employeContext;

        public EmployeeRepository(IEmployeeRepository employmentcontext)
        {
            _employeContext=employmentcontext;
        }

        public async  Task<IEnumerable<EmployModel>> GetEmployeeDetail()
        {
            return await _employeContext.EmployModel.ToListAsync();
           
        }
    }
}