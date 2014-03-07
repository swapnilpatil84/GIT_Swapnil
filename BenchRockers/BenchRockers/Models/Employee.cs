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
        
        public string Name { get; set; }
        public int RoleId { get; set; }
        public virtual Role Roles { get; set; }
        
        public string Account { get; set; }
        
        public float TotalExp { get; set; }
        
        public string Location { get; set; }
        public bool IsOnBench { get; set; }
    }
}