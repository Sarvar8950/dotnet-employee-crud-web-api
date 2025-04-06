using DAL.Dtos;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartmentAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
        Task CreateDepartmentAsync(DepartmentCreateDto department);
        Task UpdateDepartmentAsync(DepartmentUpdateDto department);
        Task DeleteDepartmentAsync(int id);
    }
}
