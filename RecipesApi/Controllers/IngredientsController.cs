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

namespace RecipesApi.Controllers
{
  [Route("api/ingredients")]
  [ApiController]
  public class IngredientsController : ControllerBase
  {
    private readonly IRepositoryWrapper _repository;

    public IngredientsController(IRepositoryWrapper repository)
    {
      _repository = repository;
    }

    // GET: api/ingredients
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
    {
      return Ok(await _repository.Ingredient.GetAllIngredientsAsync());
    }

    // GET: api/ingredients/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Ingredient>> GetIngredient(long id)
    {
      var ingredient = await _repository.Ingredient.GetIngredientByIdAsync(id);

      if (ingredient == null)
      {
        return NotFound();
      }

      return ingredient;
    }

    // PUT: api/ingredients/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRecipe(long id, Ingredient newIngredient)
    {
      if (id != newIngredient.Id)
      {
        return BadRequest();
      }

      var ingredient = await _repository.Ingredient.GetIngredientByIdAsync(id);
      if (ingredient == null)
      {
        return NotFound();
      }

      ingredient.Name = newIngredient.Name;
      ingredient.Stock = newIngredient.Stock;
      _repository.Ingredient.Update(ingredient);

      try
      {
        await _repository.SaveAsync();
      }
      catch (DbUpdateConcurrencyException) when (!IngredientExists(id))
      {
        return NotFound();
      }

      return NoContent();
    }

    // POST: api/ingredients
    [HttpPost]
    public async Task<ActionResult<Ingredient>> PostIngredient(IngredientBase newIngredient)
    {
      var ingredient = new Ingredient
      {
        Stock = newIngredient.Stock,
        Name = newIngredient.Name,
      };

      _repository.Ingredient.Create(ingredient);
      await _repository.SaveAsync();

      return CreatedAtAction(nameof(GetIngredient), new { id = ingredient.Id }, ingredient);
    }

    // DELETE: api/ingredients
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteIngredient(long id)
    {
      var ingredient = await _repository.Ingredient.GetIngredientByIdAsync(id);
      if (ingredient == null)
      {
        return NotFound();
      }

      _repository.Ingredient.Delete(ingredient);
      await _repository.SaveAsync();

      return NoContent();
    }

    // PATCH: api/ingredients
    [HttpPatch("{id}")]
    public async Task<ActionResult<Ingredient>> PatchIngredient(long id, Increment increment)
    {
      var ingredient = await _repository.Ingredient.GetIngredientByIdAsync(id);

      if (ingredient == null)
      {
        return NotFound();
      }

      ingredient.Stock = ingredient.Stock + increment.Change;
      _repository.Ingredient.Update(ingredient);
      await _repository.SaveAsync();

      return ingredient;
    }

    private bool IngredientExists(long id)
    {
      return _repository.Ingredient.FindAll().Any(e => e.Id == id);
    }
  };
}
