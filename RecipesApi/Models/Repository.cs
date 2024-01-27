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
    public async Task<Recipe?> GetRecipeByIdAsync(long id)
    {
      return await FindByCondition(recipe => recipe.Id.Equals(id))
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

    public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
    {
      return await FindAll()
        .OrderBy(ingredient => ingredient.Stock)
        .ToListAsync();
    }
    public async Task<Ingredient?> GetIngredientByIdAsync(long id)
    {
      return await FindByCondition(ingredient => ingredient.Id.Equals(id))
          .FirstOrDefaultAsync();
    }
    public void CreateIngredient(Ingredient ingredient)
    {
      Create(ingredient);
    }
    public void UpdateIngredient(Ingredient ingredient)
    {
      Update(ingredient);
    }
    public void DeleteIngredient(Ingredient ingredient)
    {
      Delete(ingredient);
    }
  }

  public class ChefRepository : RepositoryBase<Chef>, IChefRepository
  {
    public ChefRepository(RecipesContext recipesContext) : base(recipesContext)
    {
    }

    public async Task<IEnumerable<Chef>> GetAllChefsAsync()
    {
      return await FindAll()
        .OrderBy(chef => chef.Name)
        .ToListAsync();
    }

    public async Task<Chef?> GetChefByIdAsync(long id)
    {
      return await FindByCondition(chef => chef.Id.Equals(id))
          .FirstOrDefaultAsync();
    }
    public void CreateChef(Chef chef)
    {
      Create(chef);
    }
    public void UpdateChef(Chef chef)
    {
      Update(chef);
    }
    public void DeleteChef(Chef chef)
    {
      Delete(chef);
    }
  }

  public class RepositoryWrapper : IRepositoryWrapper
  {
    private RecipesContext _repoContext;
    private IRecipeRepository? _recipe;
    private IIngredientRepository? _ingredient;
    private IChefRepository? _chef;

    public RepositoryWrapper(RecipesContext repositoryContext)
    {
      _repoContext = repositoryContext;
    }

    public IRecipeRepository Recipe
    {
      get
      {
        // null-coalescing assignment only applies if left side is null
        _recipe ??= new RecipeRepository(_repoContext);
        return _recipe;
      }
    }

    public IIngredientRepository Ingredient
    {
      get
      {
        _ingredient ??= new IngredientRepository(_repoContext);
        return _ingredient;
      }
    }

    public IChefRepository Chef
    {
      get
      {
        _chef ??= new ChefRepository(_repoContext);
        return _chef;
      }
    }

    public async Task SaveAsync()
    {
      await _repoContext.SaveChangesAsync();
    }
  }
}