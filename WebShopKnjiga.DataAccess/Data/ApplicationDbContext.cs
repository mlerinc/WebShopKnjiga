using Microsoft.EntityFrameworkCore;
using WebShopKnjiga.Models.Models;

namespace WebShopKnjiga.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new
            {
                Id = 2,
                Name = "Novel",
                DisplayOrder = 2
            },
            new
            {
                Id = 3,
                Name = "Thriller",
                DisplayOrder = 3

            }
        );

        }
    }
}
