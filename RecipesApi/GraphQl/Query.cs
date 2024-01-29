using NuGet.Protocol;
using RecipesApi.Controllers;
using RecipesApi.Models;
using RecipesApi.Repository;

namespace RecipesApi.GraphQL;

public class Query
{
  public async Task<IEnumerable<Chef>> GetChefsAsync(IRepositoryWrapper repositoryWrapper)
  {
    var chefs = await repositoryWrapper.Chef.GetAllChefsAsync();
    return chefs;
  }


}