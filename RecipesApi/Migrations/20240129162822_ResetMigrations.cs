using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipesApi.Migrations
{
    /// <inheritdoc />
    public partial class ResetMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Stock = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChefId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsFavourite = table.Column<bool>(type: "boolean", nullable: false),
                    Secret = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Chefs_ChefId",
                        column: x => x.ChefId,
                        principalTable: "Chefs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientsId = table.Column<long>(type: "bigint", nullable: false),
                    RecipesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IngredientId = table.Column<long>(type: "bigint", nullable: false),
                    RecipeId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Gordron Ramsey" },
                    { 2L, "Rachael Ray" },
                    { 3L, "Ainsley Harriott" },
                    { 4L, "Matty Matheson" },
                    { 5L, "Rick Stein" },
                    { 6L, "Carla Hall" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Stock" },
                values: new object[,]
                {
                    { 1L, "onion", 35 },
                    { 2L, "carrot", 23 },
                    { 3L, "parsnip", 16 },
                    { 4L, "garlic", 32 },
                    { 5L, "celery", 12 },
                    { 6L, "potato", 26 },
                    { 7L, "tomato", 100 },
                    { 8L, "courgette", 32 },
                    { 9L, "aubergine", 25 },
                    { 10L, "pepper", 12 },
                    { 11L, "pasta", 15 },
                    { 12L, "flour", 35 },
                    { 13L, "egg", 21 },
                    { 14L, "water", 19 },
                    { 15L, "yeast", 17 },
                    { 16L, "salt", 20 },
                    { 17L, "basil", 11 },
                    { 18L, "olive oil", 15 },
                    { 19L, "black pepper", 24 },
                    { 20L, "parmesan", 25 },
                    { 21L, "mozzerella", 22 },
                    { 22L, "chocolate", 17 },
                    { 23L, "sugar", 32 },
                    { 24L, "butter", 31 },
                    { 25L, "strawberry", 29 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "ChefId", "IsFavourite", "Name", "Secret" },
                values: new object[,]
                {
                    { 1L, 1L, true, "sunday special", "don't over boil the sauce" },
                    { 2L, 2L, false, "evening delight", "timing" },
                    { 3L, 2L, true, "the welsh", "cook pasta in sauce" },
                    { 4L, 3L, false, "runners company", "consider moisture" },
                    { 5L, 3L, true, "kids plate", "hot oven" },
                    { 6L, 4L, false, "dogs dinner", "don't overbake" },
                    { 7L, 5L, true, "left overs", "cheese on every layer" },
                    { 8L, 6L, false, "monday blues", "don't over cook the veg" },
                    { 9L, 6L, true, "the stinker", "make em gooey" },
                    { 10L, 6L, false, "deutch courage", "cut the veg big" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 1L, 15L, 11, 1L },
                    { 2L, 18L, 16, 1L },
                    { 3L, 8L, 13, 1L },
                    { 4L, 11L, 7, 1L },
                    { 5L, 21L, 13, 1L },
                    { 6L, 16L, 7, 1L },
                    { 7L, 10L, 18, 1L },
                    { 8L, 24L, 14, 1L },
                    { 9L, 16L, 4, 2L },
                    { 10L, 7L, 1, 2L },
                    { 11L, 14L, 11, 2L },
                    { 12L, 1L, 12, 2L },
                    { 13L, 3L, 19, 2L },
                    { 14L, 22L, 6, 2L },
                    { 15L, 11L, 8, 3L },
                    { 16L, 15L, 4, 3L },
                    { 17L, 1L, 4, 3L },
                    { 18L, 18L, 16, 3L },
                    { 19L, 17L, 19, 3L },
                    { 20L, 9L, 17, 3L },
                    { 21L, 21L, 10, 3L },
                    { 22L, 16L, 19, 4L },
                    { 23L, 19L, 11, 4L },
                    { 24L, 17L, 19, 4L },
                    { 25L, 11L, 3, 4L },
                    { 26L, 23L, 1, 4L },
                    { 27L, 8L, 7, 4L },
                    { 28L, 24L, 8, 4L },
                    { 29L, 3L, 10, 4L },
                    { 30L, 7L, 4, 4L },
                    { 31L, 15L, 6, 4L },
                    { 32L, 20L, 16, 5L },
                    { 33L, 3L, 19, 5L },
                    { 34L, 1L, 18, 5L },
                    { 35L, 19L, 6, 5L },
                    { 36L, 12L, 6, 6L },
                    { 37L, 22L, 13, 6L },
                    { 38L, 13L, 8, 6L },
                    { 39L, 23L, 10, 6L },
                    { 40L, 2L, 11, 6L },
                    { 41L, 8L, 2, 6L },
                    { 42L, 24L, 3, 6L },
                    { 43L, 10L, 11, 6L },
                    { 44L, 19L, 11, 6L },
                    { 45L, 15L, 18, 7L },
                    { 46L, 1L, 5, 7L },
                    { 47L, 8L, 18, 7L },
                    { 48L, 23L, 1, 7L },
                    { 49L, 19L, 16, 7L },
                    { 50L, 3L, 12, 7L },
                    { 51L, 10L, 6, 7L },
                    { 52L, 7L, 2, 8L },
                    { 53L, 13L, 8, 8L },
                    { 54L, 11L, 13, 8L },
                    { 55L, 21L, 18, 8L },
                    { 56L, 3L, 11, 9L },
                    { 57L, 11L, 5, 9L },
                    { 58L, 19L, 9, 9L },
                    { 59L, 14L, 5, 9L },
                    { 60L, 4L, 14, 9L },
                    { 61L, 9L, 6, 9L },
                    { 62L, 2L, 12, 9L },
                    { 63L, 8L, 8, 9L },
                    { 64L, 1L, 15, 9L },
                    { 65L, 22L, 18, 9L },
                    { 66L, 6L, 9, 10L },
                    { 67L, 9L, 9, 10L },
                    { 68L, 19L, 17, 10L },
                    { 69L, 16L, 5, 10L },
                    { 70L, 15L, 4, 10L },
                    { 71L, 14L, 12, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_Name",
                table: "Chefs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipesId",
                table: "IngredientRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ChefId",
                table: "Recipes",
                column: "ChefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Chefs");
        }
    }
}
