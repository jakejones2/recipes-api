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
    Task<Recipe?> GetRecipeByIdAsync(long ownerId);
    void CreateRecipe(Recipe owner);
    void UpdateRecipe(Recipe owner);
    void DeleteRecipe(Recipe owner);
  }

  public interface IIngredientRepository : IRepositoryBase<Ingredient>
  {
  }

  public interface IRepositoryWrapper
  {
    IRecipeRepository Recipe { get; }
    IIngredientRepository Ingredient { get; }
    Task SaveAsync();
  }
}