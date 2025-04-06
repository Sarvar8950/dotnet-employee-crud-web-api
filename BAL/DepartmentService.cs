using DAL.Dtos;
using DAL.IDepartmentRepositry;
using DAL.IEmployeeRepositry;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<List<Department>> GetAllDepartmentAsync()
        {
            return await _departmentRepository.GetAllDepartmentAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _departmentRepository.GetDepartmentByIdAsync(id);
        }

        public async Task CreateDepartmentAsync(DepartmentCreateDto department)
        {
            await _departmentRepository.CreateDepartmentAsync(department);
        }

        public async Task UpdateDepartmentAsync(DepartmentUpdateDto department)
        {
            await _departmentRepository.UpdateDepartmentAsync(department);
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            await _departmentRepository.DeleteDepartmentAsync(id);
        }
    }
}
