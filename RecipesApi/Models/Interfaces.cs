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
    void CreateRecipe(Recipe recipe);
    void UpdateRecipe(Recipe recipe);
    void DeleteRecipe(Recipe recipe);
  }

  public interface IIngredientRepository : IRepositoryBase<Ingredient>
  {
    Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    Task<Ingredient?> GetIngredientByIdAsync(long id);
    void CreateIngredient(Ingredient ingredient);
    void UpdateIngredient(Ingredient ingredient);
    void DeleteIngredient(Ingredient ingredient);
  }

  public interface IChefRepository : IRepositoryBase<Chef>
  {
    Task<IEnumerable<Chef>> GetAllChefsAsync();
    Task<Chef?> GetChefByIdAsync(long id);
    void CreateChef(Chef chef);
    void UpdateChef(Chef chef);
    void DeleteChef(Chef chef);
  }

  public interface IRepositoryWrapper
  {
    IRecipeRepository Recipe { get; }
    IIngredientRepository Ingredient { get; }
    IChefRepository Chef { get; }
    Task SaveAsync();
  }
}