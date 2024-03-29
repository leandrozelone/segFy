﻿// <auto-generated />
using ApoliceSegfy.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApoliceSegfy.Api.Migrations
{
    [DbContext(typeof(PolicyDbContext))]
    [Migration("20190828012233_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApoliceSegfy.Api.Data.Model.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Board")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Document")
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b.Property<int>("PolicyId");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Policy");
                });
#pragma warning restore 612, 618
        }
    }
}
