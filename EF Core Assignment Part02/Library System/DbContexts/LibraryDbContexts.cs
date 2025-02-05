using Library_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.DbContexts
{
    internal class LibraryDbContexts: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=LibraryDB; integrated security=true; trust server certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>(B =>
            {
                B.ToTable("Books");

                B.HasKey(b => b.Id);

                B.Property(b => b.Title)
                 .IsRequired();

                B.Property(b => b.ISBN)
                 .IsRequired();

                B.HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
            });

            modelBuilder.Entity<Author>(A =>
            {
                A.ToTable("Authors");

                A.HasKey(a => a.Id);

                A.Property(a => a.Name)
                 .IsRequired();

                A.Property(a => a.BirthDate)
                 .IsRequired();
            });

            modelBuilder.Entity<Borrower>(B =>
            {
                B.ToTable("Borrowers");

                B.HasKey(b => b.Id);

                B.Property(b => b.Name)
                 .IsRequired();

                B.Property(b => b.MembershipDate)
                 .IsRequired();
            });


            modelBuilder.Entity<Loan>(L =>
            {
                L.ToTable("Loans");

                L.HasKey(l => new { l.BookId, l.BorrowerId });

                L.Property(l => l.LoanDate)
                 .IsRequired();

                L.Property(l => l.ReturnDate)
                 .IsRequired(false);

                // to book
                L.HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId);

                // to Borrower
                L.HasOne(l => l.Borrower)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BorrowerId);
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
