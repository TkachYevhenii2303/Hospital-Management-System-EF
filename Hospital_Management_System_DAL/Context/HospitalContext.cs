using Hospital_Management_System_DAL.Bogus;
using Hospital_Management_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Context
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; } 

        public DbSet<Roles> Roles { get; set; }

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

            var Seeding = new BogusSeeding();

            modelBuilder.Entity<Employees>().HasData(Seeding.Employees);

            modelBuilder.Entity<Roles>().HasData(Seeding.Roles);

            modelBuilder.Entity<HasRoles>().HasData(Seeding.HasRoles);
            
            modelBuilder.Entity<Hospitals>().HasData(Seeding.Hospitals);
            
            modelBuilder.Entity<InDepartments>().HasData(Seeding.InDepartments);
            
            modelBuilder.Entity<Departments>().HasData(Seeding.Departments);
            
            modelBuilder.Entity<Shedules>().HasData(Seeding.Shedules);

            modelBuilder.Entity<Patients>().HasData(Seeding.Patients);
            
            modelBuilder.Entity<PatientsCases>().HasData(Seeding.PatientsCases);

            modelBuilder.Entity<AppointmentsStatuses>().HasData(Seeding.AppointmentsStatuses);
            
            modelBuilder.Entity<Appointments>().HasData(Seeding.Appointments);

            modelBuilder.Entity<DocumentsTypes>().HasData(Seeding.DocumentsTypes);

            modelBuilder.Entity<Documents>().HasData(Seeding.Documents);
        }
    }
}
