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

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCostHistory> ItemCostHistories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseBill> PurchaseBills { get; set; }
        public DbSet<ConTableItemAndPurchaseBill> ConTableItemAndPurchaseBill { get; set; }
        public DbSet<ConTableCustomerAndBill> ConTableCustomerAndBill { get; set; }
        public DbSet<SalesBill> SalesBills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ConTableItemAndBill> ConTableItemAndBills { get; set; }


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
