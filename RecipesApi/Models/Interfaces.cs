using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;

namespace RecipesApi.Repository
{
  public interface IRepositoryBase<T>
  {
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
  }

  public interface IRecipeRepository : IRepositoryBase<Recipe>
  {
    Task<IEnumerable<Recipe>> GetAllRecipesAsync();
    Task<Recipe?> GetRecipeByIdAsync(long id);
    void CreateRecipe(Recipe id);
    void UpdateRecipe(Recipe id);
    void DeleteRecipe(Recipe id);
  }

  public interface IIngredientRepository : IRepositoryBase<Ingredient>
  {
    Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    Task<Ingredient?> GetIngredientByIdAsync(long id);
    void CreateIngredient(Ingredient id);
    void UpdateIngredient(Ingredient id);
    void DeleteIngredient(Ingredient id);
  }

  public interface IRepositoryWrapper
  {
    IRecipeRepository Recipe { get; }
    IIngredientRepository Ingredient { get; }
    Task SaveAsync();
  }
}