Just figuring out basic APIs with ASP.NET Core!

## To do

- Add integration tests
- Create endpoint that returns recipes that can be cooked with current stock
- Create seed function
- Deploy on Azure
- Create GraphQL api
- Create more unit tests
- Rename RecipesController plural, rename RecipeIngredients vs RecipeIngredient
- General refactoring
- Move some db logic into repository classes?

## Notes

Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

## Commands

```
dotnet run --launch-profile https
dotnet ef migrations add [migration name]
dotnet ef database update
```

```
mutation {
  addChef(input: {chefBase: {name: "Jake"}}) {
    chef {
      name
    }
  }
}
```
