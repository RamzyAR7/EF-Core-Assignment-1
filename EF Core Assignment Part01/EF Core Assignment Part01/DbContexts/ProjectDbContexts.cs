using EF_Core_Assignment_Part01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_Part01.DbContexts
{
    internal class ProjectDbContexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=ProjectDB; integrated security=true; trust server certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(P =>
            {
                P.ToTable("Projects");
                // id
                P.HasKey(p => p.Id);
                P.Property(p => p.Id)
                .UseIdentityColumn(10, 10);

                // name
                P.Property(P => P.Name)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasDefaultValue("OurProject");
                

                // cost
                P.Property(P => P.Cost)
                .HasColumnType("Money");
                // check constraint
                P.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
