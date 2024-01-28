using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;
using RecipesApi.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Recipes") ?? "Data Source=Recipes.db";


// Add services to the container.
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddControllers();
builder.Services.AddSqlite<RecipesContext>(connectionString);
// builder.Services.AddDbContext<RecipesContext>(opt =>
//     opt.UseInMemoryDatabase("Recipes"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();