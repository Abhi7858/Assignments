using System.Data.Entity;

namespace AtmSystem.Models
{

    public class AdminContext:DbContext
    {
        public AdminContext():base("DatabaseConnection")
        {
            
        }
        public DbSet<Admin> AdminTable { set; get; }
    }
}