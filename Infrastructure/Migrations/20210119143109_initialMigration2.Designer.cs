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
    [Migration("20210119143109_initialMigration2")]
    partial class initialMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemNo");

                    b.ToTable("ItemCostHistory");
                });

            modelBuilder.Entity("Core.Entity.Supplier", b =>
                {
                    b.Property<int>("SupllierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SsupplierPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SupplierTotalPurchases")
                        .HasColumnType("float");

                    b.HasKey("SupllierId");

                    b.ToTable("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
