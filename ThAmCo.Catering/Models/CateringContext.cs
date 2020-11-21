using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class CateringContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<Menu> Menus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Catering;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Provide seed data
            builder.Entity<FoodItem>().HasData(
                new FoodItem { FoodItemId = 1, Description = "Chicken", UnitPrice = 4.50F},
                new FoodItem { FoodItemId = 2, Description = "Beef", UnitPrice = 5.50F },
                new FoodItem { FoodItemId = 3, Description = "Lamb", UnitPrice = 6.50F }
                );

            builder.Entity<Menu>().HasData(
                new Menu { MenuId = 1, MenuName = "Wedding"},
                new Menu { MenuId = 2, MenuName = "Birthday" },
                new Menu { MenuId = 3, MenuName = "Christening" }
                );
        }
    }
}
