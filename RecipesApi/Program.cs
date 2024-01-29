using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;
using RecipesApi.GraphQL;
using RecipesApi.Repository;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING") ?? "Data Source=Recipes.db";

builder.Services.AddPooledDbContextFactory<RecipesContext>(o => o.UseNpgsql(Environment.GetEnvironmentVariable("AZURE_POSTGRESQL_CONNECTIONSTRING")));

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

builder.Logging.AddAzureWebAppDiagnostics();

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