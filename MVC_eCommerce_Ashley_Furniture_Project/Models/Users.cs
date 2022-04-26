using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }

        public string UserEmailId { get; set; }

        public string UserPassword { get; set; }

        public int RoleId{ get; set; }

    }
}
