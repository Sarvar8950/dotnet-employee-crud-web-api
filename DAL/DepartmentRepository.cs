
using DAL.Dtos;
using DAL.IDepartmentRepositry;
using DAL.Mapper;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeesContext _context;

        public DepartmentRepository(EmployeesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetAllDepartmentAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _context.Departments
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<String> CreateDepartmentAsync(DepartmentCreateDto department)
        {
            var depModel = department.ToDepartmentCreateDto();
            _context.Departments.Add(depModel);
            await _context.SaveChangesAsync();
            return "Department created";
        }

        public async Task<String> UpdateDepartmentAsync(DepartmentUpdateDto department)
        {
            var depModel = department.ToDepartmentUpdateDto();
            _context.Departments.Update(depModel);
            await _context.SaveChangesAsync();
            return "Department updated";
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> DepartmentExistsAsync(int id)
        {
            return await _context.Departments.AnyAsync(e => e.Id == id);
        }
    }
}
