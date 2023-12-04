using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreModel.data
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [MaxLength(25)]
        [MinLength(2)]
        public string Name { get; set; }
        public int Price { get; set; }//מחיר שבו קנה את המוצר
        public int Cost { get; set; }//מחיר שבו הוא מוכר את המוצר
        public int Qty { get; set; }// מלאי שקיים מהמוצר - quantity

    }
}