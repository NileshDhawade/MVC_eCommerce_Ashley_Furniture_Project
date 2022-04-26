using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        //public int RoleId { get; set; }
        //[Required]

        public int OrderId { get; set; }
          [Required]

        public int CategoryId { get; set; }
    }
}
