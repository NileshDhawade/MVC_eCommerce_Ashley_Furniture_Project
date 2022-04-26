using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_eCommerce_Ashley_Furniture_Project.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserId { get; set; }


        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(50)]
        public string UserEmailId { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(20)]
        public string UserPassword { get; set; }


        [Required]
        [DataType(DataType.Text)]
        public int RoleId{ get; set; }

    }
}
