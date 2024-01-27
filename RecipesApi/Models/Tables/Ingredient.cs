namespace RecipesApi.Models;

public class IngredientBase
{
  public string? Name { get; set; }
  public int Stock { get; set; }
}

public class Ingredient : IngredientBase
{
  public long Id { get; set; }
  public List<Recipe> Recipes { get; } = [];
  public List<RecipeIngredients> RecipeIngredients { get; } = [];
}

public class Increment
{
  public int Change { get; set; }
}

public class IngredientDTO : IngredientBase
{
  public long Id { get; set; }
}
