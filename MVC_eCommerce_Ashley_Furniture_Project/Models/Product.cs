using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public decimal ProductPrice { get; set; }


    }
}
