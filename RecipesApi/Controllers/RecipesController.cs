using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;
using RecipesApi.Repository;

namespace RecipesApi.Controllers;

[Route("api/recipes")]
[ApiController]
public class RecipesController : ControllerBase
{
    private readonly IRepositoryWrapper _repository;

    public RecipesController(IRepositoryWrapper repository)
    {
        _repository = repository;
    }

    // GET: api/recipes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipes()
    {
        var recipeDTOs = _repository.Recipe.FindAll().Select(recipe => ItemToDTO(recipe));
        var recipes = await recipeDTOs.ToAsyncEnumerable().ToListAsync();
        return Ok(recipes);
    }

    // GET: api/recipes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<RecipeDTO>> GetRecipe(long id)
    {
        var recipe = await _repository.Recipe.GetRecipeByIdAsync(id);

        if (recipe == null)
        {
            return NotFound();
        }

        return Ok(ItemToDTO(recipe));
    }

    // PUT: api/recipes/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRecipe(long id, RecipeDTO recipeDTO)
    {
        if (id != recipeDTO.Id)
        {
            return BadRequest();
        }

        var recipe = await _repository.Recipe.GetRecipeByIdAsync(id);
        if (recipe == null)
        {
            return NotFound();
        }

        recipe.Name = recipeDTO.Name;
        recipe.IsFavourite = recipeDTO.IsFavourite;
        recipe.ChefId = recipeDTO.ChefId;
        recipe.Chef = await _repository.Chef.GetChefByIdAsync(recipeDTO.ChefId);
        _repository.Recipe.Update(recipe);

        try
        {
            await _repository.SaveAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            var recipeExists = await RecipeExists(id);
            if (!recipeExists)
            {
                return NotFound();
            }
        }

        return NoContent();
    }

    // DELETE: api/recipes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRecipe(long id)
    {
        var recipe = await _repository.Recipe.GetRecipeByIdAsync(id);
        if (recipe == null)
        {
            return NotFound();
        }

        _repository.Recipe.Delete(recipe);
        await _repository.SaveAsync();

        return NoContent();
    }

    private async Task<bool> RecipeExists(long id)
    {
        return await _repository.Recipe.GetRecipeByIdAsync(id) != null;
    }

    public static RecipeDTO ItemToDTO(Recipe recipe) =>
        new()
        {
            Id = recipe.Id,
            Name = recipe.Name,
            IsFavourite = recipe.IsFavourite,
            ChefId = recipe.ChefId,
        };
}

