using Microsoft.EntityFrameworkCore;

namespace RecipesApi.Models;

public class RecipesContext : DbContext
{
  public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Chef>().HasData(Seed.GetChefs());
    modelBuilder.Entity<Ingredient>().HasData(Seed.GetIngredients());
    modelBuilder.Entity<Recipe>().HasData(Seed.GetRecipes());
    modelBuilder.Entity<RecipeIngredients>().HasData(Seed.GetRecipeIngredients());
  }

  public DbSet<Recipe> Recipes { get; set; } = null!;
  public DbSet<Ingredient> Ingredients { get; set; } = null!;
  public DbSet<Chef> Chefs { get; set; } = null!;
  public DbSet<RecipeIngredients> RecipeIngredients { get; set; } = null!;
}