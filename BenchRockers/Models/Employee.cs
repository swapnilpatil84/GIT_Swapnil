using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class Employee
    {
        public Employee() { }
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is Required")]
        public string Name { get; set; }
        public int RoleId { get; set; }
        public virtual Role Roles { get; set; }
        [Required(ErrorMessage = "Account is Required")]
        public string Account { get; set; }
        [Required(ErrorMessage = "Experience is Required")]
        public float TotalExp { get; set; }
        [Required(ErrorMessage = "Location is Required")]
        public string Location { get; set; }
        public bool IsOnBench { get; set; }
    }
}