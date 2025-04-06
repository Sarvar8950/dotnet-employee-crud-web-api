
using DAL.Dtos;
using DAL.IEmployeeRepositry;
using DAL.Mapper;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeesContext _context;

        public EmployeeRepository(EmployeesContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.Include(x => x.Department).Where(e => !e.IsDelete).ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.Include(x => x.Department)
                .FirstOrDefaultAsync(e => e.Id == id && !e.IsDelete);
        }

        public async Task<String> CreateEmployeeAsync(EmployeeCreateDto employee)
        {
            var employeeModel = employee.ToEmployCreateDto();
            employeeModel.IsDelete = false;
            _context.Employees.Add(employeeModel);
            await _context.SaveChangesAsync();
            return "Employe Created";
        }

        public async Task<String> UpdateEmployeeAsync(EmployeeUpdateDto employee)
        {
            var employeeModel = employee.ToEmployUpdateDto();
            employeeModel.IsDelete = false;
            _context.Employees.Update(employeeModel);
            await _context.SaveChangesAsync();
            return "Employe Updated";
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                employee.IsDelete = true;
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> EmployeeExistsAsync(int id)
        {
            return await _context.Employees.AnyAsync(e => e.Id == id);
        }

        public async Task<Department> GetDepartmentNameByEmployeeId(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee != null)
            {
                var department = await _context.Departments.FirstOrDefaultAsync(e => e.Id == employee.DepartmentId);
                return department;
            }
            return null;
        }
    }
}
