using Moq;
using RecipesApi.Models;
using RecipesApi.Repository;

internal class MockIRepositoryWrapper
{
  public static Mock<IRepositoryWrapper> GetMock()
  {
    var mock = new Mock<IRepositoryWrapper>();

    // setup the mock
    mock.Setup(m => m.Recipe).Returns(() => MockIRecipeRepository.GetMock().Object);
    mock.Setup(m => m.Ingredient).Returns(() => new Mock<IIngredientRepository>().Object);
    mock.Setup(m => m.SaveAsync()).Callback(() => { return; });
    return mock;
  }
}

internal class MockIRecipeRepository
{
  public static Mock<IRecipeRepository> GetMock()
  {
    var mock = new Mock<IRecipeRepository>();
    var recipes = new List<Recipe>()
    {
      new()
      {
        Id = 1,
        Name = "testRecipe",
        IsFavourite = true
      }
    };

    mock.Setup(m => m.GetAllRecipesAsync()).ReturnsAsync(recipes);
    mock.Setup(m => m.GetRecipeByIdAsync(It.IsAny<long>())).ReturnsAsync((long id) => recipes.FirstOrDefault(o => o.Id == id));
    mock.Setup(m => m.CreateRecipe(It.IsAny<Recipe>())).Callback(() => { return; });
    mock.Setup(m => m.UpdateRecipe(It.IsAny<Recipe>())).Callback(() => { return; });
    mock.Setup(m => m.DeleteRecipe(It.IsAny<Recipe>())).Callback(() => { return; });
    mock.Setup(m => m.FindAll()).Returns(recipes.AsQueryable());
    // mock.Setup(m => m.FindByCondition(It.IsAny<Func<>>())).Returns()

    return mock;
  }
}