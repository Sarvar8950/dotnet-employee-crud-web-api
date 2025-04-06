using DAL.Dtos;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public static class DepartmentMapper
    {
        public static Department ToDepartmentCreateDto(this DepartmentCreateDto dtoData)
        {
            return new Department
            {   
                Name = dtoData.Name,
                Email = dtoData.Email
            };
        }

        public static Department ToDepartmentUpdateDto(this DepartmentUpdateDto dtoData)
        {
            return new Department
            {
                Id = dtoData.Id,
                Name = dtoData.Name,
                Email = dtoData.Email
            };
        }
    }
}
