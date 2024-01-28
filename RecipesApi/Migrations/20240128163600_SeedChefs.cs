using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedChefs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Gordon Ramsey" },
                    { 2L, "Rachael Ray" },
                    { 3L, "Ainsley Harriott" },
                    { 4L, "Matty Matheson" },
                    { 5L, "Rick Stein" },
                    { 6L, "Carla Hall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
