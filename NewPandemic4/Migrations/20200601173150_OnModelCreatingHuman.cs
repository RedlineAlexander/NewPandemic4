using Microsoft.EntityFrameworkCore.Migrations;

namespace NewPandemic4.Migrations
{
    public partial class OnModelCreatingHuman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DeadCount", "Name", "Population", "RecoveredCount", "SickCount", "Vaccine" },
                values: new object[] { 3, 97811, "US", 328200000, 376266, 1647741, false });

            migrationBuilder.InsertData(
                table: "Humans",
                columns: new[] { "Id", "Age", "CountryId", "FirstName", "Gender", "IsSick", "LastName" },
                values: new object[] { 4, 54, 1, "Obi-wan", "Male", false, "Gamgee" });

            migrationBuilder.InsertData(
                table: "Humans",
                columns: new[] { "Id", "Age", "CountryId", "FirstName", "Gender", "IsSick", "LastName" },
                values: new object[] { 2, 54, 1, "Sanwise", "Male", false, "Gamgee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Humans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Humans",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
