
using BAL.Services;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employees
        [HttpGet("getAll")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        // GET: Employees/Details/5
        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: Employees/Create
        [HttpPost("create")]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateDto employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.CreateEmployeeAsync(employee);
                return Ok("Employee created successfully.");
            }
            return BadRequest("Please enter valid data.");
        }

        // POST: Employees/Update
        [HttpPost("update")]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateDto employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.UpdateEmployeeAsync(employee);
                return Ok(employee);
            }
            return BadRequest("Please enter valid data.");
        }

        // DELETE: Employees/Delete/5
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            await _employeeService.DeleteEmployeeAsync(id);
            return Ok("Employee deleted successfully.");
        }

        // GET: Employees/Details/5
        [HttpGet("getDepartmentNameByEmployeeId/{id}")]
        public async Task<IActionResult> GetDepartmentNameByEmployeeId([FromRoute] int id)
        {
            var employee = await _employeeService.GetDepartmentNameByEmployeeId(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
