using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_System_MIG.Migrations
{
    /// <inheritdoc />
    public partial class Initialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentsStatuses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusTitle = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentsStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentsTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypesTitle = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActiveIs = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesTitle = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientsCases",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsCases", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PatientsCases_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HasRoles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HasRoles_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HasRoles_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InDepartment",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveIs = table.Column<bool>(type: "bit", nullable: false),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InDepartment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InDepartment_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InDepartment_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentEndTtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientCasesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InDepartmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointments_InDepartment_InDepartmentsId",
                        column: x => x.InDepartmentsId,
                        principalTable: "InDepartment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_PatientsCases_PatientCasesId",
                        column: x => x.PatientCasesId,
                        principalTable: "PatientsCases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shedules",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InDepartmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shedules_InDepartment_InDepartmentsId",
                        column: x => x.InDepartmentsId,
                        principalTable: "InDepartment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentsLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentsDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentsTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Documents_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "Appointments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_DocumentsTypes_DocumentsTypesId",
                        column: x => x.DocumentsTypesId,
                        principalTable: "DocumentsTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_InDepartment_InDepartmentId",
                        column: x => x.InDepartmentId,
                        principalTable: "InDepartment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_PatientsCases_PatientCaseId",
                        column: x => x.PatientCaseId,
                        principalTable: "PatientsCases",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "StatusHistories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusHistories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StatusHistories_AppointmentsStatus_AppointmentStatusId",
                        column: x => x.AppointmentStatusId,
                        principalTable: "AppointmentsStatuses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StatusHistories_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "Appointments",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_InDepartmentsId",
                table: "Appointments",
                column: "InDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientCasesId",
                table: "Appointments",
                column: "PatientCasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HospitalId",
                table: "Departments",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AppointmentsId",
                table: "Documents",
                column: "AppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentsTypesId",
                table: "Documents",
                column: "DocumentsTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_InDepartmentId",
                table: "Documents",
                column: "InDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PatientCaseId",
                table: "Documents",
                column: "PatientCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PatientsId",
                table: "Documents",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_HasRoles_EmployeesId",
                table: "HasRoles",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_HasRoles_RolesId",
                table: "HasRoles",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_InDepartment_DepartmentsId",
                table: "InDepartment",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_InDepartment_EmployeesId",
                table: "InDepartment",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsCases_PatientsId",
                table: "PatientsCases",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_InDepartmentsId",
                table: "Shedules",
                column: "InDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistories_AppointmentsId",
                table: "StatusHistories",
                column: "AppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistories_AppointmentStatusId",
                table: "StatusHistories",
                column: "AppointmentStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "HasRoles");

            migrationBuilder.DropTable(
                name: "Shedules");

            migrationBuilder.DropTable(
                name: "StatusHistories");

            migrationBuilder.DropTable(
                name: "DocumentsTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AppointmentsStatuses");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "InDepartment");

            migrationBuilder.DropTable(
                name: "PatientsCases");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
