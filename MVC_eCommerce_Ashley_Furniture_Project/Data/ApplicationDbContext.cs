using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_eCommerce_Ashley_Furniture_Project.Models;
using MVC_eCommerce_Ashley_Furniture_Project.ModelView;


namespace MVC_eCommerce_Ashley_Furniture_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }

        public DbSet<Inventry> Inventry { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<MVC_eCommerce_Ashley_Furniture_Project.Models.Ordered> Ordered { get; set; }

        public DbSet<MVC_eCommerce_Ashley_Furniture_Project.ModelView.InventryModel> InventryModel { get; set; }
    }
}
