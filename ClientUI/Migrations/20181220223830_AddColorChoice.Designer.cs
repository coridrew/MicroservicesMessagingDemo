﻿// <auto-generated />
using System;
using ClientUI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClientUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20181220223830_AddColorChoice")]
    partial class AddColorChoice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientUI.Models.PlacedOrderRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Color");

                    b.Property<string>("ColorOptions");

                    b.Property<bool?>("ColorRequired");

                    b.Property<string>("ColorSelected");

                    b.Property<DateTime>("Date");

                    b.Property<string>("ItemName");

                    b.Property<string>("OrderId");

                    b.Property<int>("OrderStatus");

                    b.HasKey("Id");

                    b.ToTable("PlacedOrderRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
