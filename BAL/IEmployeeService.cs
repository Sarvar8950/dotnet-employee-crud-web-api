using DAL.Dtos;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task CreateEmployeeAsync(EmployeeCreateDto employee);
        Task UpdateEmployeeAsync(EmployeeUpdateDto employee);
        Task DeleteEmployeeAsync(int id);
        Task<Department> GetDepartmentNameByEmployeeId(int id);
    }
}
