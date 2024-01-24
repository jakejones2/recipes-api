using Microsoft.EntityFrameworkCore;

namespace RecipesApi.Models;

public class RecipesContext : DbContext
{
  public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
  {
  }

  public DbSet<Recipe> Recipes { get; set; } = null!; // used to be Recipe
  public DbSet<Ingredient> Ingredients { get; set; } = null!;
}