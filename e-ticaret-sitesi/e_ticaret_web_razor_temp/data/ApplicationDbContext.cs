using e_ticaret_web_razor_temp.Models;
using Microsoft.EntityFrameworkCore;

namespace e_ticaret_web_razor_temp.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ev eşyaları", DisplayOrder = 1 },
                new Category { Id = 2, Name = "elektronik eşyalar", DisplayOrder = 2 },
                new Category { Id = 3, Name = "ayakkanılar", DisplayOrder = 3 }
                );
        }
    }
}
