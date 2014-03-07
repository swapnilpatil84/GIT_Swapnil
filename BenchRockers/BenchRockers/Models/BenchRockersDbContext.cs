using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class BenchRockersDbContext : DbContext
    {
        public BenchRockersDbContext()
            : base("BenchRockersDbContext")
        {
            Database.SetInitializer<BenchRockersDbContext>(new BenchRockersDbInitializer());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }

        public DbSet<Role> Roles { get; set; }
    }

    public class BenchRockersDbInitializer : DropCreateDatabaseIfModelChanges<BenchRockersDbContext>
    {
        protected override void Seed(BenchRockersDbContext context)
        {
            IList<Skill> defaultSkills = new List<Skill>();

            defaultSkills.Add(new Skill() { Name = "ASP .Net"});
            defaultSkills.Add(new Skill() { Name = "C#" });
            defaultSkills.Add(new Skill() { Name = "VB .Net" });
            defaultSkills.Add(new Skill() { Name = "SQL Server" });
            defaultSkills.Add(new Skill() { Name = "HTML" });
            defaultSkills.Add(new Skill() { Name = "Jquery" });
            defaultSkills.Add(new Skill() { Name = "CSS" });

            foreach (Skill skill in defaultSkills)
                context.Skills.Add(skill);

            IList<Role> defaultRoles = new List<Role>();

            defaultRoles.Add(new Role() { RoleName = "Software Trainee" });
            defaultRoles.Add(new Role() { RoleName = "Software Engineer" });
            defaultRoles.Add(new Role() { RoleName = "Senior Software Engineer" });
            defaultRoles.Add(new Role() { RoleName = "Software Tester" });
            defaultRoles.Add(new Role() { RoleName = "Web Designer" });
            defaultRoles.Add(new Role() { RoleName = "UI Developer" });
            defaultRoles.Add(new Role() { RoleName = "Team Lead" });
            defaultRoles.Add(new Role() { RoleName = "Project Manager" });
            defaultRoles.Add(new Role() { RoleName = "Software Architect" });

            foreach (Role role in defaultRoles)
                context.Roles.Add(role);

            base.Seed(context);

        }
    }
}