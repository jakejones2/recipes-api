namespace RecipesApi.Models;

public class Ingredient
{
  public long Id { get; set; }
  public string? Name { get; set; }
  public int Stock { get; set; }
}

public class Increment
{
  public int Change { get; set; }
}