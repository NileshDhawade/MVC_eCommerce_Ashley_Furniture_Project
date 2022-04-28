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

        public DbSet<Inventry> Inventry { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<MVC_eCommerce_Ashley_Furniture_Project.Models.Ordered> Ordered { get; set; }
    }
}
