using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class Employee
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? Salary { get; set; }

    public bool IsDelete { get; set; } = false;

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
}
