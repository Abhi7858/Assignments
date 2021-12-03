using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmSystem.Models
{
    [Table("TblCustomer")]
    public class Customer
    {
        [Key]
        public int Accountno { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }
}