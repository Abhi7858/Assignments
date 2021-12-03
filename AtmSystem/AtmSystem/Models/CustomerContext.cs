using System.Data.Entity;

namespace AtmSystem.Models
{

    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("DatabaseConnection")
        {

        }
        public DbSet<Customer> CustomerTable { set; get; }
    }
}