using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipesApi.Migrations
{
    /// <inheritdoc />
    public partial class UniqueChefNameAttempt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 10L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 6L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 16L, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 8L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 6, 1L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 5L, 16 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 11L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Quantity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 13L, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 10L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 10, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 10, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 19L, 12, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 12, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 1L, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 7, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 16L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 16, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 16, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 20L, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 17, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 8, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 17, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 7L, 12, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 6L, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 1, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 4, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 5, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 4, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 19, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 21L, 18, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 14, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 20L, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 3, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 7, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 1, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 15, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 2, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 14, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 9, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 19L, 8, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 7, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 14, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 9, 8L });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 50L, 4L, 15, 8L },
                    { 51L, 10L, 14, 8L },
                    { 52L, 16L, 2, 8L },
                    { 53L, 14L, 11, 8L },
                    { 54L, 22L, 9, 8L },
                    { 55L, 6L, 9, 8L },
                    { 56L, 22L, 6, 9L },
                    { 57L, 1L, 9, 9L },
                    { 58L, 8L, 7, 9L },
                    { 59L, 3L, 12, 9L },
                    { 60L, 14L, 1, 10L },
                    { 61L, 25L, 18, 10L },
                    { 62L, 8L, 18, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_Name",
                table: "Chefs",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chefs_Name",
                table: "Chefs");

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 13L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 9L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 19L, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 24L, 13 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 1L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 14, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 16L, 6 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 5L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 6L, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 12 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Quantity",
                value: 16);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 23L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 1, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 7, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 16, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 20L, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 1, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 6 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 14, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 14, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 19, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 4L, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 6, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 19, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 19L, 12, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 17, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 14L, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 5, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 2, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 15, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 15, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 8, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 6, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 4, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 1L, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 8, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 7L, 2, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 13, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 10, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 1, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 17, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 14L, 3, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 10, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 13, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 9, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 11, 10L });
        }
    }
}
