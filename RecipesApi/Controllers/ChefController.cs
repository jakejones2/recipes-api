using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using RecipesApi.Models;
using RecipesApi.Repository;

namespace RecipesApi.Controllers;

[Route("api/chefs")]
[ApiController]
public class ChefController : ControllerBase
{
  private readonly IRepositoryWrapper _repository;

  public ChefController(IRepositoryWrapper repository)
  {
    _repository = repository;
  }

  // GET: api/chefs
  [HttpGet]
  public async Task<ActionResult<IEnumerable<ChefDTO>>> GetChefs()
  {
    var chefs = _repository.Chef.FindAll();
    var chefDTOs = await chefs.Select(chef => new ChefDTO()
    {
      Id = chef.Id,
      Name = chef.Name,
    }).ToArrayAsync();
    return Ok(chefDTOs);
  }

  // GET: api/chefs/5/recipes
  [HttpGet]
  [Route("{chefId}/recipes")]
  public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetChefRecipes(long chefId)
  {
    var chef = await _repository.Chef
      .FindByCondition((chef) => chef.Id == chefId)
      .Include(chef => chef.Recipes)
      .SingleOrDefaultAsync();

    if (chef == null) return NotFound();

    var recipeDTOs = new List<RecipeDTO>();
    foreach (Recipe recipe in chef.Recipes)
    {
      recipeDTOs.Add(RecipesController.ItemToDTO(recipe));
    }

    return Ok(recipeDTOs);
  }

  // POST: api/chefs
  [HttpPost]
  public async Task<ActionResult<Chef>> PostChef(ChefBase chefBase)
  {
    var chef = new Chef { Name = chefBase.Name };
    _repository.Chef.Create(chef);
    await _repository.SaveAsync();

    return CreatedAtAction(nameof(GetChefs), new { id = chef.Id }, chef);
  }

  // POST: api/chefs/5/recipe
  [HttpPost]
  [Route("{chefId}/recipes")]
  public async Task<ActionResult<Recipe>> PostRecipe(long chefId, RecipeBase recipeBase)
  {
    var chef = await _repository.Chef
      .FindByCondition((chef) => chef.Id == chefId)
      .Include(chef => chef.Recipes)
      .AsTracking()
      .SingleOrDefaultAsync();

    if (chef == null) return NotFound();

    var recipe = new Recipe
    {
      Name = recipeBase.Name,
      IsFavourite = recipeBase.IsFavourite,
      Secret = recipeBase.Secret,
      ChefId = chefId,
      Chef = chef,
    };

    chef.Recipes.Add(recipe);
    await _repository.SaveAsync();

    var recipeDTO = RecipesController.ItemToDTO(recipe);
    return CreatedAtAction(nameof(PostRecipe), new { id = recipe.Id }, recipeDTO);
  }

  // DELETE: api/chefs/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteChef(long id)
  {
    var chef = await _repository.Chef.GetChefByIdAsync(id);
    if (chef == null) return NotFound();

    _repository.Chef.Delete(chef);
    await _repository.SaveAsync();

    return NoContent();
  }

  // PATCH: api/chefs/5
  [HttpPatch("{id}")]
  public async Task<ActionResult<Chef>> PatchChef(long id, ChefBase chefBase)
  {
    var chef = await _repository.Chef.GetChefByIdAsync(id);
    if (chef == null) return NotFound();

    chef.Name = chefBase.Name;
    _repository.Chef.Update(chef);

    try
    {
      await _repository.SaveAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      var chefExists = await ChefExists(id);
      if (!chefExists) return NotFound();
    }

    return NoContent();
  }

  private async Task<bool> ChefExists(long id)
  {
    return await _repository.Chef.GetChefByIdAsync(id) != null;
  }


}