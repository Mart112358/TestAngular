using System.Data.Entity;
using System.Text;

namespace TestAngularLOB.Models
{
    public class DatabaseConfiguration : DbConfiguration
    {
        public DatabaseConfiguration()
        {
            this.SetDatabaseInitializer(new DatabaseInitializer());
        }
    }
}