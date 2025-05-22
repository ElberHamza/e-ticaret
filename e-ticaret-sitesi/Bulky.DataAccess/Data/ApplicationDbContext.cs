using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models2;
using Utility2;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart>ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ev eşyaları", DisplayOrder = 1 },
                new Category { Id = 2, Name = "elektronik eşyalar", DisplayOrder = 2 },
                new Category { Id = 3, Name = "ayakkabılar", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tekinler", PhoneNumber = 123123213, City="adasd", State="asdasda",StreetAddress="sadasdasd" }
            );

            modelBuilder.Entity<Company>().HasData(
               new Company
               {
                   Id = 2,
                   Name = "Tekinler",
                   PhoneNumber = 123123213,
                   City = "adasd",
                   State = "asdasda",
                   StreetAddress = "sadasdasd",

               });

           modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7,
                    Title = "Zamanın Şansı",
                    Author = "Billy Spark",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "SWD9999002",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 8,
                    Title = "Karanlık Gökyüzü",
                    Author = "Nancy Hoover",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "CAW777777702",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 9,
                    Title = "Gün Batımında Kaybolmak",
                    Author = "Julian Button",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "RITO5555502",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 10,
                    Title = "Pamuk Şeker",
                    Author = "Abby Muscles",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "WS3333333302",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 11,
                    Title = "Okyanusta Kaya",
                    Author = "Ron Parker",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "SOTJ1111111102",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 12,
                    Title = "Yapraklar ve Harikalar",
                    Author = "Laura Phantom",
                    Description = "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.",
                    ISBN = "FOT000000002",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 1
                    
                }
            );
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
