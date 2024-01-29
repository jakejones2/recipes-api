using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;
using RecipesApi.GraphQL;
using RecipesApi.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Recipes") ?? "Data Source=Recipes.db";

builder.Services.AddPooledDbContextFactory<RecipesContext>(o => o.UseSqlite(connectionString));

builder.Services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();

builder.Services
    .AddGraphQLServer()
    .RegisterService<IRepositoryWrapper>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    //.AddDefaultTransactionScopeHandler()  // this doesn't work in SQLite?
    .AddMutationConventions(applyToAllMutations: true);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();