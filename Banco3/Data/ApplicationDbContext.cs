using Banco3.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        public DbSet<Financial> Financial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Financial>().HasData(new Financial
            {
                Id = 1,
                Code = "001",
                ProductCode = "001",
                Price = 200.00m
            });

            modelBuilder.Entity<Financial>().HasData(new Financial
            {
                Id = 2,
                Code = "002",
                ProductCode = "002",
                Price = 100.00m
            });

            modelBuilder.Entity<Financial>().HasData(new Financial
            {
                Id = 3,
                Code = "003",
                ProductCode = "003",
                Price = 1200.00m
            });

            modelBuilder.Entity<Financial>().HasData(new Financial
            {
                Id = 4,
                Code = "004",
                ProductCode = "004",
                Price = 5100.00m
            });

            modelBuilder.Entity<Financial>().HasData(new Financial
            {
                Id = 5,
                Code = "005",
                ProductCode = "005",
                Price = 11100.00m
            });
        }
    }
}
