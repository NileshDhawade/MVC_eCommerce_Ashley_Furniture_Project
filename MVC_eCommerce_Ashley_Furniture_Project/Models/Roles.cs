using System.ComponentModel.DataAnnotations;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    public class Roles
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
