﻿// <auto-generated />
using System;
using FoodLog.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodLog.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodLog.Domain.Entity.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grams")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryType = 7,
                            Date = new DateTime(2020, 7, 14, 11, 37, 27, 784, DateTimeKind.Utc).AddTicks(3361),
                            Grams = 350,
                            Name = "Tuna"
                        });
                });

            modelBuilder.Entity("FoodLog.Domain.Entity.Nutrient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Grams")
                        .HasColumnType("float");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("NutrientType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Nutrients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Grams = 2.1000000000000001,
                            ItemId = 1,
                            NutrientType = 0
                        },
                        new
                        {
                            Id = 2,
                            Grams = 0.0,
                            ItemId = 1,
                            NutrientType = 1
                        },
                        new
                        {
                            Id = 3,
                            Grams = 101.5,
                            ItemId = 1,
                            NutrientType = 2
                        });
                });

            modelBuilder.Entity("FoodLog.Domain.Entity.Nutrient", b =>
                {
                    b.HasOne("FoodLog.Domain.Entity.Item", null)
                        .WithMany("Nutrients")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
