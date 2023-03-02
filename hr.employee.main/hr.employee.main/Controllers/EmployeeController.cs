using hr.employee.main.Data;
using hr.employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hr.employee.main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext employeeDbContext;

        public EmployeeController(EmployeeDbContext employeeDbContext) 
        {
            this.employeeDbContext = employeeDbContext;
        }
        [HttpGet]
        [Route("employee/all")]
        public IActionResult GetEmployeeDetails()
        {
           return Ok(employeeDbContext.Employee.ToList());
           // return Ok(new Employee { Id= 101, Name="Nitin Jadhav", Designation="Software Developer", City="Satara", Age=27, Salary=30000 } );
        }


    }
}
