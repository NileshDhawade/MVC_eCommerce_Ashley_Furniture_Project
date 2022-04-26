using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
