Just figuring out basic APIs with ASP.NET Core!
Mostly proof of concept - endpoints lack proper testing and error handling.

## To do

- Try basic integration tests
- Fully unit tests REST controllers
- Unit test graphQL endpoint?
- Fully build graphQL endpoint
- Deploy on Azure
- Refactor names, e.g. RecipeIngredients vs RecipeIngredient
- Move some controller fetching logic into repository classes?

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
