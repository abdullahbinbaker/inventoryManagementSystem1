using Core;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
        public DbSet<ItemCostHistory> ItemCostHistory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        //public DbSet<RefreshToken> RefreshTokens { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Employee>().Property(m => m.Id).IsRequired();
        //    modelBuilder.Entity<Login>().Property(m => m.EmployeeId).ValueGeneratedNever();
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee()
        //        //1, "abdullah salem", "Admin@gmail.com", "0568039837", "Male", "Admin", new DateTime(200, 04, 06),
        //        //   1, 30)
        //        {
        //            Id = 1,
        //            Name = "abdullah salem",
        //            EmailAddress = "Admin@gmail.com",
        //            MobileNumber = "055555",
        //            Gender = "Male",
        //            Role = "Admin",
        //            BirthDate = new DateTime(1994, 09, 17),
        //            ManagerId = 1,
        //            VacationDaysAllowedYearly = 30


        //        }
        //        );

        //    modelBuilder.Entity<Login>().HasData(
        //      new Login
        //      //(1, "Admin@gmail.com", "Admin")
        //      {
        //          EmployeeId = 1,
        //          EmailAddress = "Admin@gmail.com",
        //          Password = "Admin"
        //      }
        //      );
        //}


    }
}
