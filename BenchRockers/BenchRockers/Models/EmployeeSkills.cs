using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class EmployeeSkill
    {
        public int EmployeeSkillId { get; set; }
        public int EmpId { get; set; }
        public virtual Employee Employees { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skills { get; set; }
        public int Rating { get; set; }
    }
}