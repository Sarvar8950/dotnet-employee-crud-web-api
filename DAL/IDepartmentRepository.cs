using DAL.Dtos;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.IDepartmentRepositry
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllDepartmentAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
        Task<String> CreateDepartmentAsync(DepartmentCreateDto department);
        Task<String> UpdateDepartmentAsync(DepartmentUpdateDto department);
        Task DeleteDepartmentAsync(int id);
        Task<bool> DepartmentExistsAsync(int id);
    }
}
