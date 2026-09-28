using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService= employeeService;
        }

        [HttpGet("/")]
        public async Task<IActionResult> GetEmploy()
        {
                var employees = _employeeService.GetEmployeeAsync();
                return Ok(employee);
        }
    }
}
