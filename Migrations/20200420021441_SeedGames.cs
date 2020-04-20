using Microsoft.EntityFrameworkCore.Migrations;

namespace Esportshere.Migrations
{
    public partial class SeedGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "games",
                columns: new[] { "id", "name", "short_name" },
                values: new object[,]
                {
                    { 1L, "Counter Strike: Global Offensive", "CS:GO" },
                    { 2L, "League of Legends", "LoL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
