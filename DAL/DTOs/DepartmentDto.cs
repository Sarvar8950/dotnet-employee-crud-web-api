using System;
using System.Collections.Generic;

namespace DAL.Dtos
{
    public class DepartmentCreateDto
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
    }

    public class DepartmentUpdateDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
    }
}

