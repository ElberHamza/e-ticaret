﻿// <auto-generated />
using DataAccess2.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241228235626_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models2.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "ev eşyaları"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "elektronik eşyalar"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "ayakkanılar"
                        });
                });

            modelBuilder.Entity("Models2.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy Spark",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "SWD9999001",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Zamanın Şansı"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Nancy Hoover",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "CAW777777701",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Karanlık Gökyüzü"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Julian Button",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "RITO5555501",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Gün Batımında Kaybolmak"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Abby Muscles",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "WS3333333301",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "Pamuk Şeker"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Ron Parker",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "SOTJ1111111101",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Okyanusta Kaya"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Laura Phantom",
                            CategoryId = 0,
                            Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                            ISBN = "FOT000000001",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "Yapraklar ve Harikalar"
                        });
                });

            modelBuilder.Entity("Models2.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("Models2.Product", b =>
                {
                    b.HasOne("Models2.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Models2.ProductImage", b =>
                {
                    b.HasOne("Models2.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models2.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
