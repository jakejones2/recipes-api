namespace RecipesApi.Models;

public class ChefBase
{
  public string? Name { get; set; }

}

public class Chef : ChefBase
{
  public long Id { get; set; }
  public ICollection<Recipe> Recipes { get; } = new List<Recipe>();
}

public class ChefDTO : ChefBase
{
  public long Id { get; set; }
}