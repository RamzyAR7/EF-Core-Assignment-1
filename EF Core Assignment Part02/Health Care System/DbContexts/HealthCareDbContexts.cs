using Health_Care_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.DbContexts
{
    internal class HealthCareDbContexts:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=HealthCareDB; integrated security=true; trust server certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doctor>(D =>
            {
                D.ToTable("Doctors");

                D.HasKey(d => d.Id);

                D.Property(d => d.Name)
                .IsRequired();

                D.Property(d => d.Specialization)
                .IsRequired();

            });

            modelBuilder.Entity<Patient>(P =>
            {
                P.ToTable("Patients");

                P.HasKey(p => p.Id);

                P.Property(p => p.Name)
                .IsRequired();

                P.Property(p => p.DateOfBirth)
                .IsRequired();

            });

            modelBuilder.Entity<Appointment>(A =>
            {
                A.ToTable("Appointments");

                A.HasKey(a => new {a.PatientId, a.DoctorId});

                A.Property(a => a.AppointmentDate)
                .IsRequired();

                // to Patient
                A.HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId);

                // to Doctor
                A.HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
