
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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;


        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // GET: Department
        [HttpGet("getAll")]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            var employees = await _departmentService.GetAllDepartmentAsync();
            return Ok(employees);
        }

        // GET: Department/Details/5
        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] int id)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        // POST: Department/Create
        [HttpPost("create")]
        public async Task<IActionResult> CreateEmployee(DepartmentCreateDto department)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.CreateDepartmentAsync(department);
                return Ok("Department created successfully.");
            }
            return BadRequest("Please enter valid data.");
        }

        // POST: Department/Update
        [HttpPost("update")]
        public async Task<IActionResult> UpdateDepartment(DepartmentUpdateDto department)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.UpdateDepartmentAsync(department);
                return Ok(department);
            }
            return BadRequest("Please enter valid data.");
        }

        // DELETE: Department/Delete/5
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var employee = await _departmentService.GetDepartmentByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            await _departmentService.DeleteDepartmentAsync(id);
            return Ok("Department deleted successfully.");
        }
    }
}
