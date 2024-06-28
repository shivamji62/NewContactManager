﻿// <auto-generated />
using System;
using ContactManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManager.Migrations
{
    [DbContext(typeof(ContactManagerContext))]
    [Migration("20240626123156_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, City, Country",
                            CreatedOn = new DateTime(2024, 6, 26, 18, 1, 56, 246, DateTimeKind.Local).AddTicks(1884),
                            Email = "first.test@example.com",
                            Name = "First Test",
                            Phone = "9874563218",
                            UpdatedOn = new DateTime(2024, 6, 26, 18, 1, 56, 246, DateTimeKind.Local).AddTicks(1874)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
