using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }
        public int EmpId { get; set; }
        public virtual Employee Employees { get; set; }
        public string SupervisorName{ get; set; }
        public string Description { get; set; }
    }
}