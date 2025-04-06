using DAL.Dtos;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public static class EmployeeMapper
    {
        public static Employee ToEmployCreateDto(this EmployeeCreateDto dtoData)
        {
            return new Employee
            {   
                Name = dtoData.Name,
                Position = dtoData.Position,
                Salary = dtoData.Salary,
                DepartmentId = dtoData.DepartmentId
            };
        }
        public static Employee ToEmployUpdateDto(this EmployeeUpdateDto dtoData)
        {
            return new Employee
            {
                Id = dtoData.Id,
                Name = dtoData.Name,
                Position = dtoData.Position,
                Salary = dtoData.Salary,
                DepartmentId = dtoData.DepartmentId
            };
        }
    }
}
