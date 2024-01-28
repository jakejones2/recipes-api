using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using NuGet.Protocol;

namespace RecipesApi.Models;

public static class Seed
{
  public static List<Chef> GetChefs()
  {
    string[] chefNames = [
      "Gordron Ramsey",
      "Rachael Ray",
      "Ainsley Harriott",
      "Matty Matheson",
      "Rick Stein",
      "Carla Hall",
    ];

    var chefs = new List<Chef>();
    int id = 1;
    foreach (string chefName in chefNames)
    {
      chefs.Add(new Chef()
      {
        Id = id,
        Name = chefName,
      });
      id++;
    }

    return chefs;
  }

  public static List<Ingredient> GetIngredients()
  {
    (string, int)[] ingredientsData = [
      ("onion", 35),
      ("carrot", 23),
      ("parsnip", 16),
      ("garlic", 32),
      ("celery", 12),
      ("potato", 26),
      ("tomato", 100),
      ("courgette", 32),
      ("aubergine", 25),
      ("pepper", 12),
      ("pasta", 15),
      ("flour", 35),
      ("egg", 21),
      ("water", 19),
      ("yeast", 17),
      ("salt", 20),
      ("basil", 11),
      ("olive oil", 15),
      ("black pepper", 24),
      ("parmesan", 25),
      ("mozzerella", 22),
      ("chocolate", 17),
      ("sugar", 32),
      ("butter", 31),
      ("strawberry", 29),
    ];

    var ingredients = new List<Ingredient>();
    long id = 1;
    foreach ((string, int) ingredientData in ingredientsData)
    {
      var ingredient = new Ingredient()
      {
        Id = id,
        Name = ingredientData.Item1,
        Stock = ingredientData.Item2,
      };
      ingredients.Add(ingredient);
      id++;
    }

    return ingredients;
  }

  public static List<Recipe> GetRecipes()
  {
    // there are 6 chefs

    (string, int, bool, string)[] recipeData = [
      ("sunday special", 1, true, "don't over boil the sauce"),
      ("evening delight", 2, false, "timing"),
      ("the welsh", 2, true, "cook pasta in sauce"),
      ("runners company", 3, false, "consider moisture"),
      ("kids plate", 3, true, "hot oven"),
      ("dogs dinner", 4, false, "don't overbake"),
      ("left overs", 5, true, "cheese on every layer"),
      ("monday blues", 6, false, "don't over cook the veg"),
      ("the stinker", 6, true, "make em gooey"),
      ("deutch courage", 6, false, "cut the veg big"),
    ];

    var recipes = new List<Recipe>();
    long id = 1;
    foreach ((string, int, bool, string) recipeDataPoint in recipeData)
    {
      Recipe recipe = new Recipe()
      {
        Id = id,
        Name = recipeDataPoint.Item1,
        ChefId = recipeDataPoint.Item2,
        IsFavourite = recipeDataPoint.Item3,
        Secret = recipeDataPoint.Item4,
      };
      recipes.Add(recipe);
      id++;
    }

    return recipes;
  }

  public static List<RecipeIngredients> GetRecipeIngredients()
  {
    var ingredients = GetIngredients();
    var recipes = GetRecipes();
    var recipeIngredients = new List<RecipeIngredients>();
    long id = 1;
    foreach (Recipe recipe in recipes)
    {
      var numberSequence = GenerateRandomNumberSequence(ingredients.Count);
      Console.WriteLine($"{recipe.Id}, {numberSequence.ToJson()}");
      foreach (long randomIngredientId in numberSequence)
      {
        var newRecipeIngredientsEntry = new RecipeIngredients()
        {
          Id = id,
          RecipeId = recipe.Id,
          IngredientId = randomIngredientId,
          Quantity = Random.Shared.Next(1, 20),
        };
        recipeIngredients.Add(newRecipeIngredientsEntry);
        id++;
      }
    }

    return recipeIngredients;
  }

  public static List<long> GenerateRandomNumberSequence(int max)
  {
    int length = Random.Shared.Next(3, 11);
    var numbers = new List<long>();
    while (numbers.Count < length)
    {
      long newNumber = Random.Shared.Next(1, max + 1);
      if (!numbers.Contains(newNumber))
      {
        numbers.Add(newNumber);
      }
    }
    return numbers;
  }
}