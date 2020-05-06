using System;
using System.Collections.Generic;
using System.Text;
using GarageShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GarageShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ServiceType> ServiceType { get; set; }

        public DbSet<Car> Car { get; set; }

        public DbSet<ServiceHeader> ServiceHeader { get; set; }

        public DbSet<ServiceDetails> ServiceDetail { get; set; }

        public DbSet<ServiceShoppingCart> ServiceShoppingCart { get; set; }


        public DbSet<PaymentDetails> PaymentDetails { get; set; } 
    }
}
