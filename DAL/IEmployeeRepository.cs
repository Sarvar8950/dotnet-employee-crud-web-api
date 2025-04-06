
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.IEmployeeRepositry
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<String> CreateEmployeeAsync(EmployeeCreateDto employee);
        Task<String> UpdateEmployeeAsync(EmployeeUpdateDto employee);
        Task DeleteEmployeeAsync(int id);
        Task<bool> EmployeeExistsAsync(int id);
        Task<Department> GetDepartmentNameByEmployeeId(int id);
    }
}