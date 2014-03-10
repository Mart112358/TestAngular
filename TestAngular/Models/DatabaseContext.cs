using System.Data.Entity;

namespace TestAngularLOB.Models
{
    [DbConfigurationType(typeof(DatabaseConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}