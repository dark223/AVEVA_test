using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repos.Employees;
namespace WebAPI.Controllers
{
    /// <summary>
    /// The controller where the Repository gets called to get/create/update the enties of the employees database table 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    { 
        private readonly IEmployeeRopo _EmployeeRepo;

        public EmployeeController( IEmployeeRopo EmployeeRepo)
        {
            _EmployeeRepo = EmployeeRepo;
        }

        /// <summary>
        /// Gets all employees in the employees table
        /// </summary>
        /// <returns>returns a list of all employees</returns>
        [HttpGet("GetEmployeeList")]
        public IEnumerable<Employee> Get()
        {
          return _EmployeeRepo.Get();
        }

        /// <summary>
        /// Get all employees that satisfy the criteria specified by the user
        /// </summary>
        /// <param name="field">the column in the table</param>
        /// <param name="value">the value the user searches for</param>
        /// <returns>returns a list of employees</returns>
        [HttpGet("GetFilteredEmployeeList")]
        public IEnumerable<Employee> Getfiltered(string field, string value)
        {
            return _EmployeeRepo.Get(field, value);
        }

        /// <summary>
        /// Creates a new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>the status of the creation process</returns>
        [HttpPost("CreateEmployee")]
        public IActionResult Post([FromBody] EmployeeDTO employee)
        {
            string result;
            if (ModelState.IsValid)
            {
                result = _EmployeeRepo.Create(employee);
            }
            else
            {
                result = "Employee did not conform to format";
            }
            switch (result)
            {
                case "Employee created":
                    return Ok(result);

                case "Already exists":
                    return Ok("Already exists");

                default: return BadRequest(result);
            }
        }

        /// <summary>
        /// Updates an existing employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>returns the status of the updating process</returns>
        [HttpPut("UpdateEmployee")]
        public IActionResult Put([FromBody] Employee employee)
        {
            string result;
            if (ModelState.IsValid)
            {
                result = _EmployeeRepo.Update(employee);
            }
            else
            {
                result = "Employee did not conform to format";
            }

            switch (result)
            {
                case "Employee updated":
                    return Ok(result);

                case "Employee not found":
                    return NotFound("Employee not found");

                default: return BadRequest(result);
            }
        }
    }
}