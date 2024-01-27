using Xunit;
using Microsoft.AspNetCore.Mvc;
using RecipesApi.Controllers;
using RecipesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace RecipesControllerTests;

public class RecipeControllerTests
{
    readonly RecipesController recipesController;

    public RecipeControllerTests()
    {
        var repositoryWrapperMock = MockIRepositoryWrapper.GetMock();
        recipesController = new RecipesController(repositoryWrapperMock.Object);
    }

    [Fact]
    public async Task Returns_Recipe_Given_Valid_Id()
    {
        long id = 1;
        var result = await recipesController.GetRecipe(id);
        var okResult = result.Result as OkObjectResult;

        Assert.NotNull(okResult);
        Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        Assert.IsAssignableFrom<RecipeDTO>(okResult.Value);
    }

    [Fact]
    public async Task Returns_404_Given_Invalid_Id_Of_Recipe()
    {
        long id = 120484;
        var result = await recipesController.GetRecipe(id);
        var notFoundResult = result.Result as NotFoundResult;

        Assert.NotNull(notFoundResult);
        Assert.Equal(StatusCodes.Status404NotFound, notFoundResult.StatusCode);
    }

    [Fact]
    public async Task Returns_Array_Of_Recipes()
    {
        var result = await recipesController.GetRecipes();
        var okResult = result.Result as OkObjectResult;
        var recipes = okResult?.Value as IEnumerable<RecipeDTO>;

        Assert.NotNull(okResult);
        Assert.IsAssignableFrom<IEnumerable<RecipeDTO>>(okResult.Value);
        Assert.NotNull(recipes);
        Assert.NotEmpty(recipes);
    }
}