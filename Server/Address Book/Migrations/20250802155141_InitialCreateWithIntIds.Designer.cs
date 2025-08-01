﻿// <auto-generated />
using System;
using Address_Book.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Address_Book.Migrations
{
    [DbContext(typeof(AddressBookDbContext))]
    [Migration("20250802155141_InitialCreateWithIntIds")]
    partial class InitialCreateWithIntIds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.7");

            modelBuilder.Entity("Address_Book.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            City = "Cape Town",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "john.doe@example.com",
                            FullName = "John Doe",
                            PhoneNumber = "+27-21-123-4567",
                            Province = "Western Cape",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "8001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "789 High Street",
                            City = "Pretoria",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "mpho.mokwena@example.com",
                            FullName = "Mpho Mokwena",
                            PhoneNumber = "+27-12-234-5678",
                            Province = "Gauteng",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "0001"
                        },
                        new
                        {
                            Id = 3,
                            Address = "456 Oak Avenue",
                            City = "Johannesburg",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "jane.smith@example.com",
                            FullName = "Jane Smith",
                            PhoneNumber = "+27-11-234-5678",
                            Province = "Gauteng",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "2001"
                        },
                        new
                        {
                            Id = 4,
                            Address = "321 Pine Street",
                            City = "Pretoria",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "thabo.nkosi@example.com",
                            FullName = "Thabo Nkosi",
                            PhoneNumber = "+27-12-345-6789",
                            Province = "Gauteng",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "0002"
                        },
                        new
                        {
                            Id = 5,
                            Address = "789 Pine Road",
                            City = "Durban",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "michael.johnson@example.com",
                            FullName = "Michael Johnson",
                            PhoneNumber = "+27-31-345-6789",
                            Province = "KwaZulu-Natal",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "4001"
                        },
                        new
                        {
                            Id = 6,
                            Address = "123 Willow Street",
                            City = "Durban",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "lindiwe.dlamini@example.com",
                            FullName = "Lindiwe Dlamini",
                            PhoneNumber = "+27-31-456-7890",
                            Province = "KwaZulu-Natal",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "4001"
                        },
                        new
                        {
                            Id = 7,
                            Address = "321 Elm Street",
                            City = "Bloemfontein",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "sarah.williams@example.com",
                            FullName = "Sarah Williams",
                            PhoneNumber = "+27-51-456-7890",
                            Province = "Free State",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "9301"
                        },
                        new
                        {
                            Id = 8,
                            Address = "654 Maple Lane",
                            City = "Port Elizabeth",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "david.brown@example.com",
                            FullName = "David Brown",
                            PhoneNumber = "+27-41-567-8901",
                            Province = "Eastern Cape",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "6001"
                        },
                        new
                        {
                            Id = 9,
                            Address = "987 Cedar Road",
                            City = "Bloemfontein",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "sipho.khumalo@example.com",
                            FullName = "Sipho Khumalo",
                            PhoneNumber = "+27-51-567-8901",
                            Province = "Free State",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "9301"
                        },
                        new
                        {
                            Id = 10,
                            Address = "456 Birch Street",
                            City = "Lephalale",
                            CreatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            Email = "deltaslep@gmail.com",
                            FullName = "Deltas Lephalal",
                            PhoneNumber = "+27-15-678-9012",
                            Province = "Limpopo",
                            UpdatedAt = new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc),
                            ZipCode = "0555"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
