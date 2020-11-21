﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Catering.Models;

namespace ThAmCo.Catering.Migrations
{
    [DbContext(typeof(CateringContext))]
    partial class CateringContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThAmCo.Catering.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<float>("UnitPrice");

                    b.HasKey("FoodItemId");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            FoodItemId = 1,
                            Description = "Chicken",
                            UnitPrice = 4.5f
                        },
                        new
                        {
                            FoodItemId = 2,
                            Description = "Beef",
                            UnitPrice = 5.5f
                        },
                        new
                        {
                            FoodItemId = 3,
                            Description = "Lamb",
                            UnitPrice = 6.5f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
