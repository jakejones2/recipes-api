using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllAttemptLongId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 20L, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 23L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 7L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Quantity",
                value: 17);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 3L, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 19L, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 13L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 6L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 17L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 18L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 3L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 1L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 17L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 6L, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 13L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 9, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 20L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 2L, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 11L, 13 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 7L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 8L, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 5, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 17, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 19, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 18, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 9, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 13, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 12, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 11, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 10, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 14L, 4, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 5, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 19, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 3L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 13, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 21L, 4, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 11, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 7, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 10, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 19L, 1, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 2, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 16, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51L,
                column: "RecipeId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52L,
                column: "RecipeId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 9, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 6, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 7, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 13, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 2, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 11, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 21L, 11, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 2, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 11, 10L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 17L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 11L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Quantity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 8L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 20L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 14L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 19L, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 24L, 12 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 9L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 2L, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 17L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 9 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 20L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 16 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 18L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 1, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 4, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 11L, 13 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 20L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 13L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 2, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 22L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 8, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 5, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 19, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 5, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 13, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 14, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 3, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 5, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 16, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 17, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 17, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 3, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 13, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 9, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 17, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 4, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 12, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 15, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51L,
                column: "RecipeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52L,
                column: "RecipeId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 13, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 3, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 14, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 10, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 7, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 18, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 9, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 8, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 9, 9L });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 62L, 6L, 14, 9L },
                    { 63L, 8L, 6, 9L },
                    { 64L, 11L, 5, 10L },
                    { 65L, 22L, 15, 10L },
                    { 66L, 4L, 4, 10L },
                    { 67L, 10L, 11, 10L },
                    { 68L, 3L, 8, 10L },
                    { 69L, 1L, 5, 10L },
                    { 70L, 18L, 15, 10L },
                    { 71L, 13L, 15, 10L }
                });
        }
    }
}
