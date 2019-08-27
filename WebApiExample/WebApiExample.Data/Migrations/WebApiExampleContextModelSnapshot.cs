﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiExample.Data;

namespace WebApiExample.Data.Migrations
{
    [DbContext(typeof(WebApiExampleContext))]
    partial class WebApiExampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiExample.Data.Entities.Customer", b =>
                {
                    b.Property<decimal>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("decimal(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<decimal>("Mobile")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("decimal(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1m,
                            Email = "john.doe@test.com",
                            Mobile = 9234567891m,
                            Name = "John Doe"
                        });
                });

            modelBuilder.Entity("WebApiExample.Data.Entities.Transaction", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<decimal>("CustomerID")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("decimal(10)");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Amount = 22.3m,
                            Currency = "USD",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 26, 21, 51, 27, 889, DateTimeKind.Local).AddTicks(3604),
                            Status = "Success"
                        },
                        new
                        {
                            ID = 2L,
                            Amount = 2500.3m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 25, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9404),
                            Status = "Success"
                        },
                        new
                        {
                            ID = 3L,
                            Amount = 27800.3m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 24, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9422),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 4L,
                            Amount = 200.3m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 23, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9425),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 5L,
                            Amount = 200.31m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 22, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9427),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 6L,
                            Amount = 200.32m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 21, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9430),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 7L,
                            Amount = 200.31m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 20, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9432),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 8L,
                            Amount = 200.31m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 19, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9438),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 9L,
                            Amount = 200.31m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 18, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9440),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 10L,
                            Amount = 200.31m,
                            Currency = "THB",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9443),
                            Status = "Canceled"
                        },
                        new
                        {
                            ID = 11L,
                            Amount = 200.31m,
                            Currency = "JPY",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9445),
                            Status = "Failed"
                        },
                        new
                        {
                            ID = 12L,
                            Amount = 200.31m,
                            Currency = "JPY",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9448),
                            Status = "Failed"
                        },
                        new
                        {
                            ID = 13L,
                            Amount = 200.31m,
                            Currency = "JPY",
                            CustomerID = 1m,
                            Date = new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9450),
                            Status = "Failed"
                        });
                });

            modelBuilder.Entity("WebApiExample.Data.Entities.Transaction", b =>
                {
                    b.HasOne("WebApiExample.Data.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
