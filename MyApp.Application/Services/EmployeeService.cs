namespace MyApp.Core.ServiceContract
{
    public class EmployeeService : IEmployeeService
    {
        protected readonly IEmployeeRepository _context;

        public EmployeeService(IEmployeeRepository context)
        {
            _context= context;
        }

        public async Task<IEnumerable<CityDTO>> GetEmployeeAsync()
        {
            var employ = _context.IEmployeeRepository.ToListAsync();
            return employ.Select(x=> new CityDTO
            {
                id= x.EmployeeId;
                firstName= x.FirstName;
                lastName=x.LastName;
            });
        }

    }
}