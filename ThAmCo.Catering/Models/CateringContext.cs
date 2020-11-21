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

        public DbSet<FoodBooking> FoodBookings { get; set; }

        public DbSet<MenuFoodItem> MenuFoodItems { get; set; }

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

            builder.Entity<FoodBooking>().HasData(
                new FoodBooking { FoodBookingId = 1, ClientReferenceId = 1, NumberOfGuests = 22, MenuId = 2},
                new FoodBooking { FoodBookingId = 2, ClientReferenceId = 1, NumberOfGuests = 17, MenuId = 1},
                new FoodBooking { FoodBookingId = 3, ClientReferenceId = 16, NumberOfGuests = 7, MenuId = 3},
                new FoodBooking { FoodBookingId = 4, ClientReferenceId = 5, NumberOfGuests = 19, MenuId = 2}
                );

            builder.Entity<MenuFoodItem>().HasData(
                new MenuFoodItem { MenuFoodItemId = 1, MenuId = 1, FoodItemId = 1},
                new MenuFoodItem { MenuFoodItemId = 2, MenuId = 1, FoodItemId = 2},
                new MenuFoodItem { MenuFoodItemId = 3, MenuId = 2, FoodItemId = 3},
                new MenuFoodItem { MenuFoodItemId = 4, MenuId = 3, FoodItemId = 1},
                new MenuFoodItem { MenuFoodItemId = 5, MenuId = 3, FoodItemId = 3}
                );
        }
    }
}
