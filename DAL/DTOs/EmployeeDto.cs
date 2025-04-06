using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Dtos
{
    public class EmployeeCreateDto
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Salary { get; set; }
        public int DepartmentId { get; set; }
    }

    public class EmployeeUpdateDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}

