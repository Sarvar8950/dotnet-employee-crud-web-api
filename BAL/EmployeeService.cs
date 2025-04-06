using DAL.Dtos;
using DAL.IEmployeeRepositry;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task CreateEmployeeAsync(EmployeeCreateDto employee)
        {
            await _employeeRepository.CreateEmployeeAsync(employee);
        }

        public async Task UpdateEmployeeAsync(EmployeeUpdateDto employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<Department> GetDepartmentNameByEmployeeId(int id)
        {
            return await _employeeRepository.GetDepartmentNameByEmployeeId(id);
        }
    }
}
