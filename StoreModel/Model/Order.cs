using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.data
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy ")]
        public DateTime Date { get; set; }
        public int QtyProduct { get; set; }
        public Customer Customer { get; set; }
    }
}
