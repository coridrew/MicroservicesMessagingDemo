﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.Data;

namespace Sales.Migrations
{
    [DbContext(typeof(OrdersDbContext))]
    [Migration("20181221194709_AddColors")]
    partial class AddColors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sales.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new { Id = 1, Name = "Red" },
                        new { Id = 2, Name = "Blue" },
                        new { Id = 3, Name = "Green" }
                    );
                });

            modelBuilder.Entity("Sales.Models.SubmittedOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColorId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("SubmittedOrders");
                });

            modelBuilder.Entity("Sales.Models.SubmittedOrder", b =>
                {
                    b.HasOne("Sales.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");
                });
#pragma warning restore 612, 618
        }
    }
}
