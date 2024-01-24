using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;

namespace RecipesApi.Controllers
{
  [Route("api/ingredients")]
  [ApiController]
  public class IngredientsController : ControllerBase
  {
    private readonly RecipesContext _context;

    public IngredientsController(RecipesContext context)
    {
      _context = context;
    }

    // GET: api/ingredients
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
    {
      return await _context.Ingredients.ToListAsync();
    }

    // GET: api/ingredients/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Ingredient>> GetIngredient(long id)
    {
      var ingredient = await _context.Ingredients.FindAsync(id);

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

      var ingredient = await _context.Ingredients.FindAsync(id);
      if (ingredient == null)
      {
        return NotFound();
      }

      ingredient.Name = newIngredient.Name;
      ingredient.Stock = newIngredient.Stock;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException) when (!IngredientExists(id))
      {
        return NotFound();
      }

      return NoContent();
    }

    // POST: api/ingredients
    [HttpPost]
    public async Task<ActionResult<Ingredient>> PostIngredient(Ingredient newIngredient)
    {
      var ingredient = new Ingredient
      {
        Stock = newIngredient.Stock,
        Name = newIngredient.Name,
      };

      _context.Ingredients.Add(ingredient);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetIngredient), new { id = ingredient.Id }, ingredient);
    }

    // DELETE: api/ingredients
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteIngredient(long id)
    {
      var ingredient = await _context.Ingredients.FindAsync(id);
      if (ingredient == null)
      {
        return NotFound();
      }

      _context.Ingredients.Remove(ingredient);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    // PATCH: api/ingredients
    [HttpPatch("{id}")]
    public async Task<ActionResult<Ingredient>> PatchIngredient(long id, Increment increment)
    {
      var ingredient = _context.Ingredients.Find(id);

      if (ingredient == null)
      {
        return NotFound();
      }

      ingredient.Stock = ingredient.Stock + increment.Change;
      await _context.SaveChangesAsync();

      return ingredient;
    }

    private bool IngredientExists(long id)
    {
      return _context.Ingredients.Any(e => e.Id == id);
    }
  };
}
