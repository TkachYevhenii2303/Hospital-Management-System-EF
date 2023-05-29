﻿// <auto-generated />
using System;
using Hospital_Management_System_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Management_System_MIG.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230529043820_InsertedRoles")]
    partial class InsertedRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Appointments", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentEndTtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AppointmentStartTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InDepartmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientCasesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("InDepartmentsId");

                    b.HasIndex("PatientCasesId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.AppointmentsStatuses", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("AppointmentsStatuses");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Departments", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HospitalId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Documents", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppointmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentsDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentsLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DocumentsTypesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InDepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientCaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AppointmentsId");

                    b.HasIndex("DocumentsTypesId");

                    b.HasIndex("InDepartmentId");

                    b.HasIndex("PatientCaseId");

                    b.HasIndex("PatientsId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.DocumentsTypes", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("DocumentsTypes");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Employees", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ActiveIs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.HasRoles", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("RolesId");

                    b.ToTable("HasRoles");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Hospitals", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.InDepartments", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ActiveIs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeTo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("InDepartments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Patients", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.PatientsCases", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PatientsId");

                    b.ToTable("PatientsCases");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Roles", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RolesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Shedules", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InDepartmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("InDepartmentsId");

                    b.ToTable("Shedules");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.StatusHistories", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppointmentStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppointmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AppointmentStatusId");

                    b.HasIndex("AppointmentsId");

                    b.ToTable("StatusHistories");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "09e6481e-39bc-4d1b-a14e-3bcdf0c227bf",
                            ConcurrencyStamp = "2efed519-8985-4a68-a306-339fa94afa2b",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "955ad36f-62ef-4e73-923a-0a4e3ce9b8ae",
                            ConcurrencyStamp = "fbdbbcc1-021c-43a7-a905-4397f6d50df3",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Appointments", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.InDepartments", "InDepartment")
                        .WithMany("Appointments")
                        .HasForeignKey("InDepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.PatientsCases", "PatientsCases")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientCasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InDepartment");

                    b.Navigation("PatientsCases");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Departments", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.Hospitals", "Hospital")
                        .WithMany("Departments")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Documents", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.Appointments", "Appointments")
                        .WithMany("Documents")
                        .HasForeignKey("AppointmentsId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.DocumentsTypes", "DocumentsTypes")
                        .WithMany("Documents")
                        .HasForeignKey("DocumentsTypesId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.InDepartments", "InDepartment")
                        .WithMany("Documents")
                        .HasForeignKey("InDepartmentId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.PatientsCases", "PatientsCases")
                        .WithMany("Documents")
                        .HasForeignKey("PatientCaseId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.Patients", "Patients")
                        .WithMany("Documents")
                        .HasForeignKey("PatientsId")
                        .IsRequired();

                    b.Navigation("Appointments");

                    b.Navigation("DocumentsTypes");

                    b.Navigation("InDepartment");

                    b.Navigation("Patients");

                    b.Navigation("PatientsCases");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.HasRoles", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.Employees", "Employees")
                        .WithMany("HasRoles")
                        .HasForeignKey("EmployeesId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.Roles", "Roles")
                        .WithMany("HasRoles")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.InDepartments", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.Departments", "Departments")
                        .WithMany("InDepartments")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.Employees", "Employees")
                        .WithMany("InDepartments")
                        .HasForeignKey("EmployeesId")
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.PatientsCases", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.Patients", "Patients")
                        .WithMany("PatientsCases")
                        .HasForeignKey("PatientsId")
                        .IsRequired();

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Shedules", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.InDepartments", "InDepartment")
                        .WithMany("Shedules")
                        .HasForeignKey("InDepartmentsId")
                        .IsRequired();

                    b.Navigation("InDepartment");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.StatusHistories", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.AppointmentsStatuses", "AppointmentsStatus")
                        .WithMany("StatusHistories")
                        .HasForeignKey("AppointmentStatusId")
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.Appointments", "Appointments")
                        .WithMany("StatusHistories")
                        .HasForeignKey("AppointmentsId")
                        .IsRequired();

                    b.Navigation("Appointments");

                    b.Navigation("AppointmentsStatus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_System_DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hospital_Management_System_DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Appointments", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("StatusHistories");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.AppointmentsStatuses", b =>
                {
                    b.Navigation("StatusHistories");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Departments", b =>
                {
                    b.Navigation("InDepartments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.DocumentsTypes", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Employees", b =>
                {
                    b.Navigation("HasRoles");

                    b.Navigation("InDepartments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Hospitals", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.InDepartments", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Documents");

                    b.Navigation("Shedules");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Patients", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("PatientsCases");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.PatientsCases", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("Hospital_Management_System_DAL.Entities.Roles", b =>
                {
                    b.Navigation("HasRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
