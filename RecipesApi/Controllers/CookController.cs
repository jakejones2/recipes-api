using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using RecipesApi.Models;
using RecipesApi.Repository;

namespace RecipesApi.Controllers;

[Route("api/cook")]
[ApiController]
public class CookController : ControllerBase
{
  private readonly IRepositoryWrapper _repository;

  public CookController(IRepositoryWrapper repository)
  {
    _repository = repository;
  }

  // GET /api/cook
  [HttpGet]
  public async Task<ActionResult<IEnumerable<CookDTO>>> GetCookableRecipes()
  {
    var ingredients = await _repository.Ingredient.GetAllIngredientsAsync();
    var chefs = await _repository.Chef.GetAllChefsAsync();
    var recipes = await _repository.Recipe
      .FindAll()
      .Include(recipe => recipe.RecipeIngredients)
      .ToArrayAsync();

    var recipesAvailable = new List<CookDTO>();

    foreach (Recipe recipe in recipes)
    {
      var cookIngredients = new List<CookIngredient>();
      bool validRecipe = true;

      foreach (RecipeIngredients recipeIngredient in recipe.RecipeIngredients)
      {
        var ingredient = ingredients.FirstOrDefault(i => i.Id == recipeIngredient.IngredientId);
        if (ingredient == null || recipeIngredient.Quantity > ingredient.Stock)
        {
          validRecipe = false;
          break;
        };
        var cookIngredient = new CookIngredient()
        {
          IngredientName = ingredient.Name,
          QuantityNeeded = recipeIngredient.Quantity,
        };
        cookIngredients.Add(cookIngredient);
      }

      if (!validRecipe) continue;

      var chef = chefs.FirstOrDefault(c => c.Id == recipe.ChefId);
      var cookDTO = new CookDTO()
      {
        RecipeName = recipe.Name,
        RecipeId = recipe.Id,
        ChefName = chef == null ? "unknown" : chef.Name,
        ChefId = recipe.ChefId,
        Ingredients = cookIngredients,
      };

      recipesAvailable.Add(cookDTO);
    }

    return Ok(recipesAvailable);
  }

  // POST /api/cook/5
  [HttpPost]
  [Route("{id}")]
  public async Task<ActionResult<IEnumerable<IngredientDTO>>> PostCookingARecipe(long id)
  {
    var recipe = await _repository.Recipe
      .FindByCondition(r => r.Id == id)
      .Include(r => r.RecipeIngredients)
      .FirstOrDefaultAsync();

    if (recipe == null) return NotFound();

    var ingredients = await _repository.Ingredient.FindAll().AsTracking().ToArrayAsync();
    var ingredientDTOs = new List<IngredientDTO>();

    foreach (RecipeIngredients recipeIngredient in recipe.RecipeIngredients)
    {
      var ingredient = ingredients.FirstOrDefault(i => i.Id == recipeIngredient.IngredientId);
      if (ingredient == null) continue;
      if (ingredient.Stock < recipeIngredient.Quantity)
      {
        return BadRequest($"You have't got enough {ingredient.Name}s for this the {recipe.Name} recipe, and you wasted ingredients in the process of trying!");
      }
      else
      {
        ingredient.Stock -= recipeIngredient.Quantity;
      }
      ingredientDTOs.Add(IngredientsController.IngredientToDTO(ingredient));
    }

    await _repository.SaveAsync();

    return Ok(ingredientDTOs);
  }
}