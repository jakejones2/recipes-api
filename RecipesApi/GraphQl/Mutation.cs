using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using RecipesApi.Models;
using RecipesApi.Repository;

namespace RecipesApi.GraphQL;

public class Mutation
{
  // [Error(typeof(ChefAlreadyTakenException))]
  // [Error(typeof(DbUpdateException))]
  public async Task<Chef> AddChef(ChefBase chefBase, IRepositoryWrapper repositoryWrapper)
  {
    var chef = new Chef()
    {
      Name = chefBase.Name
    };
    repositoryWrapper.Chef.Create(chef);
    await repositoryWrapper.SaveAsync();
    return chef;
  }
}

public class ChefAlreadyTakenException : Exception
{
  public ChefAlreadyTakenException(string chefName) : base($"The chef {chefName} already exists!")
  {
  }
}