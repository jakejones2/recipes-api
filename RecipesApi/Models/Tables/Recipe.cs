using RecipesApi.Repository;

namespace RecipesApi.Models;

public class RecipeBase
{
  public string? Name { get; set; }
  public bool IsFavourite { get; set; }
  public string? Secret { get; set; }
}

public class Recipe : RecipeBase
{
  public long Id { get; set; }
  public Chef? Chef { get; set; }
  public long ChefId { get; set; }
  public List<Ingredient> Ingredients { get; } = [];
  public List<RecipeIngredients> RecipeIngredients { get; } = [];
}

// Data Transfer Object avoids exposing the whole model

public class RecipeDTO
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public bool IsFavourite { get; set; }
  public long ChefId { get; set; }
}