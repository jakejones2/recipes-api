public class RecipeIngredients
{
  public long Id { get; set; }
  public long IngredientId { get; set; }
  public long RecipeId { get; set; }
  public int Quantity { get; set; } = 1;
}

public class RecipeIngredient
{
  public long IngredientId { get; set; }
  public string? IngredientName { get; set; }
  public int? Stock { get; set; }
  public int QuantityNeeded { get; set; }
}

public class PatchRecipeIngredient
{
  public int QuantityNeeded { get; set; }
  public long IngredientId { get; set; }
}

public class CookIngredient
{
  public string? IngredientName { get; set; }
  public int QuantityNeeded { get; set; }
}

public class CookDTO
{
  public string? RecipeName { get; set; }
  public long RecipeId { get; set; }
  public string? ChefName { get; set; }
  public long ChefId { get; set; }
  public List<CookIngredient>? Ingredients { get; set; }
}