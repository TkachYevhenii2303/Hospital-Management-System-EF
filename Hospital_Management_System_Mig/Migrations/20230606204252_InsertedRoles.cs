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
                    { "499c7dd3-3df6-4f23-b977-2d1c422810ee", "1203fca6-f37f-454c-93fe-202d87195b0d", "Visitor", "VISITOR" },
                    { "5cc8a580-f144-422d-9665-d56113eab9bc", "7765793b-9b71-47b3-a7d7-e2692f6ef7fb", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "499c7dd3-3df6-4f23-b977-2d1c422810ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cc8a580-f144-422d-9665-d56113eab9bc");
        }
    }
}
