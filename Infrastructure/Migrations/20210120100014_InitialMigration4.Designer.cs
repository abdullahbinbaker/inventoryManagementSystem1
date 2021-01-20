﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210120100014_InitialMigration4")]
    partial class InitialMigration4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entity.ConTableItemAndPurchaseBill", b =>
                {
                    b.Property<string>("ItemNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ItemPriceInTheBill")
                        .HasColumnType("float");

                    b.Property<int>("ItemQuantityInTheBill")
                        .HasColumnType("int");

                    b.Property<double>("ItemTotalPriceInTheBill")
                        .HasColumnType("float");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("purchaseBillBillNo")
                        .HasColumnType("int");

                    b.HasKey("ItemNo");

                    b.HasIndex("purchaseBillBillNo");

                    b.ToTable("ConTableItemAndPurchaseBill");
                });

            modelBuilder.Entity("Core.Entity.Item", b =>
                {
                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("CurrentCost")
                        .HasColumnType("float");

                    b.Property<int?>("CurrentInventory")
                        .HasColumnType("int");

                    b.Property<string>("Location1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameArabic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price1")
                        .HasColumnType("float");

                    b.Property<double?>("Price2")
                        .HasColumnType("float");

                    b.Property<double?>("Price3")
                        .HasColumnType("float");

                    b.Property<int?>("Purchases")
                        .HasColumnType("int");

                    b.Property<int?>("Sales")
                        .HasColumnType("int");

                    b.Property<int?>("StockForTheFirstTerm")
                        .HasColumnType("int");

                    b.Property<int?>("StockForTheLastTerm")
                        .HasColumnType("int");

                    b.HasKey("ItemNo");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Core.Entity.ItemCostHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ItemCostHistory");
                });

            modelBuilder.Entity("Core.Entity.PurchaseBill", b =>
                {
                    b.Property<int>("BillNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BillTotalPriceAfterDiscount")
                        .HasColumnType("float");

                    b.Property<double>("BillTotalPriceBeforeDiscount")
                        .HasColumnType("float");

                    b.Property<string>("BillType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("OriginalPurchaseBillNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierSupllierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BillNo");

                    b.HasIndex("SupplierSupllierId");

                    b.ToTable("PurchaseBill");
                });

            modelBuilder.Entity("Core.Entity.Supplier", b =>
                {
                    b.Property<int>("SupllierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SupplierTotalPurchases")
                        .HasColumnType("float");

                    b.HasKey("SupllierId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Core.Entity.ConTableItemAndPurchaseBill", b =>
                {
                    b.HasOne("Core.Entity.PurchaseBill", "purchaseBill")
                        .WithMany()
                        .HasForeignKey("purchaseBillBillNo");
                });

            modelBuilder.Entity("Core.Entity.PurchaseBill", b =>
                {
                    b.HasOne("Core.Entity.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierSupllierId");
                });
#pragma warning restore 612, 618
        }
    }
}
