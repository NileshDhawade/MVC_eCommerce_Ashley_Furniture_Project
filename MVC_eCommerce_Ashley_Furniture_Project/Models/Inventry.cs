using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Inventry")]
    public class Inventry
    {

        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Filed Required")]
        [DataType(DataType.Text)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Filed Required")]
        [Display(Name = "CategoryName")]
        public int CategoryId { get; set; }
        [NotMapped]
        public string? CategoryName { get; set; }
        public decimal ProductPrice { get; set; }

        public string ProductImageUrl { get; set; }

        [NotMapped]

        public IFormFile ImageFile { get; set; }


    }
}
