﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApi.DbContexts;

#nullable disable

namespace ProductApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220724113406_duyada")]
    partial class duyada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductApi.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Category 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Category 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Category 5"
                        });
                });

            modelBuilder.Entity("ProductApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Product 3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Product 4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Thasdsadasdsadsadsa",
                            Name = "Product 5"
                        });
                });

            modelBuilder.Entity("ProductApi.Entities.Product", b =>
                {
                    b.HasOne("ProductApi.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
