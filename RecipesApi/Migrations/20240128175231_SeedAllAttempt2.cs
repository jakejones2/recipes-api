using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllAttempt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 19L, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 12L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 5L, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 9L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 23L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 6L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 1L, 12 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 24L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 7L, 4, 1L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 18L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                column: "IngredientId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 23L, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 7L, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 11, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 16, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 8, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 3L, 1, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 1L, 12, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 14, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 2, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 6, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 10, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 9, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 19, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 19, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 19, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 20L, 11, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 8, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 7L, 7, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 1, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 20L, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 19, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 17, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 6, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 19, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 12, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 4, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 1, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 2L, 5L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 10, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 10, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 7L, 6, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 14L, 9, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 6, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 21L, 5, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 20L, 3, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 6, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 16, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 12, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 12, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 19L, 16, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 7, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 17, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 1, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 17, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 8, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 11, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 19, 9L });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 61L, 18L, 9, 9L },
                    { 62L, 2L, 9, 9L },
                    { 63L, 3L, 8, 10L },
                    { 64L, 19L, 4, 10L },
                    { 65L, 10L, 3, 10L },
                    { 66L, 9L, 4, 10L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61L);

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

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 3L, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 10L, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 8L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 15L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 4L, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 25L, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 7L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 20L, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 8, 2L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 19L, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 2L, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12L,
                column: "IngredientId",
                value: 20L);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IngredientId", "Quantity" },
                values: new object[] { 9L, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 4L, 3L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 9L, 15, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 21L, 18, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 23L, 18, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 6, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 3, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 6, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 7, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 12, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 11, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 1, 4L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Quantity", "RecipeId" },
                values: new object[] { 13, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 18L, 7, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 11, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 11L, 19, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 4, 6L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 15, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 1, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 11, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 18L, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 8, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 10, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 7, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 14L, 1, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 18, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 6, 7L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 24L, 14, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[] { 23L, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 13L, 13, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 20L, 16, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 3, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 25L, 6, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 16L, 19, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 0L, 17, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 22L, 17, 8L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 1L, 19, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 17L, 15, 9L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 20L, 9, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 8L, 11, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 15L, 5, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 2L, 17, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 12L, 1, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 5L, 3, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 0L, 5, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 6L, 0, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 4L, 4, 10L });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { 10L, 1, 10L });
        }
    }
}
