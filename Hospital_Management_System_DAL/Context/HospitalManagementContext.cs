using Hospital_Management_System_DAL.Bogus;
using Hospital_Management_System_DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Context
{
    public class HospitalManagementContext : DbContext
    {
        public HospitalManagementContext(DbContextOptions<HospitalManagementContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<HasRoles> HasRoles { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<InDepartments> InDepartments { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Shedules> Shedules { get; set; }   
        public DbSet<Patients> Patients { get; set; }
        public DbSet<PatientsCases> PatientsCases { get; set; }
        public DbSet<AppointmentsStatuses> AppointmentsStatuses { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<StatusHistories> StatusHistories { get; set; }
        public DbSet<DocumentsTypes> DocumentsTypes { get; set; }   
        public DbSet<Documents> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var seeding = new BogusSeeding();

            modelBuilder.Entity<Employees>().HasData(seeding.Employees);
            modelBuilder.Entity<Positions>().HasData(seeding.Positions);
            modelBuilder.Entity<HasRoles>().HasData(seeding.HasRoles);
            modelBuilder.Entity<Hospitals>().HasData(seeding.Hospitals);
            modelBuilder.Entity<InDepartments>().HasData(seeding.InDepartments);
            modelBuilder.Entity<Departments>().HasData(seeding.Departments);
            modelBuilder.Entity<Shedules>().HasData(seeding.Shedules);
            modelBuilder.Entity<Patients>().HasData(seeding.Patients);
            modelBuilder.Entity<PatientsCases>().HasData(seeding.PatientsCases);
            modelBuilder.Entity<AppointmentsStatuses>().HasData(seeding.AppointmentsStatuses);
            modelBuilder.Entity<Appointments>().HasData(seeding.Appointments);
            modelBuilder.Entity<DocumentsTypes>().HasData(seeding.DocumentsTypes);
            modelBuilder.Entity<Documents>().HasData(seeding.Documents);
        }
    }
}
