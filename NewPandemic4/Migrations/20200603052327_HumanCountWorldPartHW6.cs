using Microsoft.EntityFrameworkCore.Migrations;

namespace NewPandemic4.Migrations
{
    public partial class HumanCountWorldPartHW6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AuthorIdId",
                table: "News",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorldParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorldParts_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DeadCount", "Name", "Population", "RecoveredCount", "SickCount", "Vaccine" },
                values: new object[,]
                {
                    { 4, 31309, "Brazil", 209500000, 241000, 558000, false },
                    { 5, 27127, "Spain", 46940000, 150000, 240000, false },
                    { 6, 206, "Morocco", 36300000, 6410, 7866, false },
                    { 7, 4634, "China", 193000000, 78314, 83021, false },
                    { 8, 102, "Australia", 24000000, 7219, 7219, false }
                });

            migrationBuilder.InsertData(
                table: "WorldParts",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, null, "America North" },
                    { 2, null, "America Sourth" },
                    { 3, null, "Europe" },
                    { 4, null, "Asia" },
                    { 5, null, "Africa" },
                    { 6, null, "Australia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorIdId",
                table: "News",
                column: "AuthorIdId");

            migrationBuilder.CreateIndex(
                name: "IX_WorldParts_CountryId",
                table: "WorldParts",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Humans_AuthorIdId",
                table: "News",
                column: "AuthorIdId",
                principalTable: "Humans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Humans_AuthorIdId",
                table: "News");

            migrationBuilder.DropTable(
                name: "WorldParts");

            migrationBuilder.DropIndex(
                name: "IX_News_AuthorIdId",
                table: "News");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "AuthorIdId",
                table: "News");

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
    }
}
