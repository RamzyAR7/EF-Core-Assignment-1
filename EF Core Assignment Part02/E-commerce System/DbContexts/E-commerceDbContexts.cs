using E_commerce_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.DbContexts
{
    internal class E_commerceDbContexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=E-commerceDB; integrated security=true; trust server certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(P =>
            {
                P.ToTable("Products");

                P.HasKey(p => p.Id);

                P.Property(P => P.Name)
                .IsRequired();

                P.Property(p => p.Price)
                 .IsRequired();

                P.HasOne(p => p.Category)
                 .WithMany(c => c.Products)
                 .HasForeignKey(p => p.CategoryId);
            });

            modelBuilder.Entity<Category>(C =>
            {
                C.ToTable("Categories");

                C.Property(C => C.Name)
                  .IsRequired();

                C.HasKey(c => c.Id);
            });

            modelBuilder.Entity<Order>(O =>
            {
                O.ToTable("Orders");

                O.HasKey(O => O.Id);

                O.Property(o => o.OrderDate)
                .IsRequired();

                O.HasOne(O => O.Customer)
                .WithMany(C => C.Orders)
                .HasForeignKey(O => O.CustomerId);
            });

            modelBuilder.Entity<Customer>(C =>
            {
                C.ToTable("Customers");

                C.Property(C => C.Name)
                .IsRequired();

                C.Property(c => c.Email)
                 .IsRequired();

                C.HasKey(c => c.Id);
            });

            modelBuilder.Entity<OrderDetail>(OD =>
            {
                OD.ToTable("OrderDetails");

                OD.HasKey(OD => new { OD.OrderId, OD.ProductId });

                OD.Property(od => od.Quantity)
                 .IsRequired();

                // to Products
                OD.HasOne(OD => OD.Product)
                .WithMany(P => P.OrderDetails)
                .HasForeignKey(OD => OD.ProductId);

                // to Orders
                OD.HasOne(OD => OD.Order)
                .WithMany(O => O.OrderDetails)
                .HasForeignKey(OD => OD.OrderId);
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
