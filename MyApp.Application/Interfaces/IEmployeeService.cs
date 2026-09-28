namespace MyApp.Core.ServiceContract
{
    public interface IEmployeeService
    {
         Task<IEnumerable<CityDTO>> GetEmployeeAsync();
    }
}