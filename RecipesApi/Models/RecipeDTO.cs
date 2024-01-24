namespace RecipesApi.Models;

// Data Transfer Object avoids exposing the whole model

public class RecipeDTO
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public bool IsFavourite { get; set; }
}