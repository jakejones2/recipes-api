using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;

namespace RecipesApi.Repository
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected RecipesContext Context { get; set; }
    public RepositoryBase(RecipesContext recipesContext)
    {
      Context = recipesContext;
    }

    public IQueryable<T> FindAll() => Context.Set<T>().AsNoTracking();
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            Context.Set<T>().Where(expression).AsNoTracking();
    public void Create(T entity) => Context.Set<T>().Add(entity);
    public void Update(T entity) => Context.Set<T>().Update(entity);
    public void Delete(T entity) => Context.Set<T>().Remove(entity);
  }

  public class RecipeRepository : RepositoryBase<Recipe>, IRecipeRepository
  {
    public RecipeRepository(RecipesContext recipesContext) : base(recipesContext)
    {
    }

    public async Task<IEnumerable<Recipe>> GetAllRecipesAsync()
    {
      return await FindAll()
        .OrderBy(recipe => recipe.Name)
        .ToListAsync();
    }
    public async Task<Recipe?> GetRecipeByIdAsync(long recipeId)
    {
      return await FindByCondition(recipe => recipe.Id.Equals(recipeId))
          .FirstOrDefaultAsync();
    }
    public void CreateRecipe(Recipe recipe)
    {
      Create(recipe);
    }
    public void UpdateRecipe(Recipe recipe)
    {
      Update(recipe);
    }
    public void DeleteRecipe(Recipe recipe)
    {
      Delete(recipe);
    }
  }
  public class IngredientRepository : RepositoryBase<Ingredient>, IIngredientRepository
  {
    public IngredientRepository(RecipesContext recipesContext) : base(recipesContext)
    {
    }
  }

  public class RepositoryWrapper : IRepositoryWrapper
  {
    private RecipesContext _repoContext;
    private IRecipeRepository? _recipe;
    private IIngredientRepository? _ingredient;

    public IRecipeRepository Recipe
    {
      get
      {
        if (_recipe == null)
        {
          _recipe = new RecipeRepository(_repoContext);
        }

        return _recipe;
      }
    }

    public IIngredientRepository Ingredient
    {
      get
      {
        if (_ingredient == null)
        {
          _ingredient = new IngredientRepository(_repoContext);
        }
        return _ingredient;
      }
    }

    public RepositoryWrapper(RecipesContext repositoryContext)
    {
      _repoContext = repositoryContext;
    }

    public async Task SaveAsync()
    {
      await _repoContext.SaveChangesAsync();
    }
  }
}