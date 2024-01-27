namespace RecipesApi.Models;

public class IngredientBase
{
  public string? Name { get; set; }
  public int Stock { get; set; }
}

public class Ingredient : IngredientBase
{
  public long Id { get; set; }
}

public class Increment
{
  public int Change { get; set; }
}
