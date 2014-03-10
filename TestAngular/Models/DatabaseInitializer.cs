using System;
using System.Data.Entity;

namespace TestAngularLOB.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            CreateEmployee(context);
        }

        private static void CreateEmployee(DatabaseContext context)
        {
            context.Employees.AddRange(new[]
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Martin",
                    LastName = "Paquin"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Vincent",
                    LastName = "Paquin"
                }
            });
        }
    }
}