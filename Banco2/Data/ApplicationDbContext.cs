using Banco2.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }


        public DbSet<Product> Product { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Code = "001",
                Name = "Internet Fibre 600M",
                CustomerCode = "001"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Code = "002",
                Name = "Internet Fibre 500M",
                CustomerCode = "002"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Code = "003",
                Name = "Cloud",
                CustomerCode = "003"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Code = "004",
                Name = "Server to Data Center",
                CustomerCode = "004"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Code = "005",
                Name = "Satélite",
                CustomerCode = "005"
            });
        }
    }
}
