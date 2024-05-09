using Banco1.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }


        public DbSet<Customer> Customer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer 
            { 
                Id = 1, 
                Code = "001", 
                FirstName = "Albert",
                MiddleName = "",
                SurName = "Einstein"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                Code = "002",
                FirstName = "John",
                MiddleName = "Knoch",
                SurName = "Wurth"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                Code = "003",
                FirstName = "Mattew",
                MiddleName = "Smith",
                SurName = "Fisher"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 4,
                Code = "004",
                FirstName = "Sally",
                MiddleName = "Dur",
                SurName = "Muller"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 5,
                Code = "005",
                FirstName = "Joseph",
                MiddleName = "Mont",
                SurName = "Morgan"
            });

        }  
    }
}
