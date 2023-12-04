using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.data
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        //[RegularExpression("^(07(\\d ?){9})", ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}
