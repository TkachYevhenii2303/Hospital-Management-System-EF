using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System_MIG.Migrations
{
    /// <inheritdoc />
    public partial class InsertedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09e6481e-39bc-4d1b-a14e-3bcdf0c227bf", "2efed519-8985-4a68-a306-339fa94afa2b", "Visitor", "VISITOR" },
                    { "955ad36f-62ef-4e73-923a-0a4e3ce9b8ae", "fbdbbcc1-021c-43a7-a905-4397f6d50df3", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e6481e-39bc-4d1b-a14e-3bcdf0c227bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "955ad36f-62ef-4e73-923a-0a4e3ce9b8ae");
        }
    }
}
