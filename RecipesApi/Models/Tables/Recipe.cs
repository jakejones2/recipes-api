using RecipesApi.Repository;

namespace RecipesApi.Models;

public class Recipe
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public bool IsFavourite { get; set; }
  public string? Secret { get; set; }
}

// Data Transfer Object avoids exposing the whole model

public class RecipeDTO
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public bool IsFavourite { get; set; }
}