﻿// <auto-generated />
using Banco1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Banco1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Banco1.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SurName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "001",
                            FirstName = "Albert",
                            MiddleName = "",
                            SurName = "Einstein"
                        },
                        new
                        {
                            Id = 2,
                            Code = "002",
                            FirstName = "John",
                            MiddleName = "Knoch",
                            SurName = "Wurth"
                        },
                        new
                        {
                            Id = 3,
                            Code = "003",
                            FirstName = "Mattew",
                            MiddleName = "Smith",
                            SurName = "Fisher"
                        },
                        new
                        {
                            Id = 4,
                            Code = "004",
                            FirstName = "Sally",
                            MiddleName = "Dur",
                            SurName = "Muller"
                        },
                        new
                        {
                            Id = 5,
                            Code = "005",
                            FirstName = "Joseph",
                            MiddleName = "Mont",
                            SurName = "Morgan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}