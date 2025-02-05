﻿// <auto-generated />
using EF_Core_Assignment_Part01.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core_Assignment_Part01.Migrations
{
    [DbContext(typeof(ProjectDbContexts))]
    [Migration("20250205123702_AddProjectTB")]
    partial class AddProjectTB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Core_Assignment_Part01.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<decimal>("Cost")
                        .HasColumnType("Money");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("OurProject");

                    b.HasKey("Id");

                    b.ToTable("Projects", null, t =>
                        {
                            t.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
