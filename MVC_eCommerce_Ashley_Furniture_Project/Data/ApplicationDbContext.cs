using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVC_eCommerce_Ashley_Furniture_Project.Models;

namespace MVC_eCommerce_Ashley_Furniture_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Orders> orders { get; set; }
    }
}
