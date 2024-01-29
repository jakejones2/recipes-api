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

### Azure details

Web App + Database by Microsoft

Resource Group: recipes-api
Name: recipes-api-v1
Publish: Code
Runtime stack: .NET 8 (LTS)

#### Web app

Name: ASP-recipesapi-861e
Operating System: Linux
Region: UK South
SKU: Basic
Size: Small
ACU: 100 total ACU
Memory: 1.75 GB memory

#### Cache

Cache name: recipes-api-v1-cache

#### Networking

Virtual Network: (New) recipes-api-v1Vnet (10.0.0.0/16)
Inbound subnet: (New) recipes-api-v1Subnet (10.0.0.0/24)
DNS: Azure Private DNS Zone
Outbound subnet (Web App): (New) recipes-api-v1AppSubnet (10.0.1.0/24)
Outbound subnet (Database): (New) recipes-api-v1DbSubnet (10.0.2.0/24)

#### Database

Server name: recipes-api-v1-server
Engine: PostgreSQL - Flexible Server
Compute tier and size: Burstable Standard_B1ms
Database name: recipes-api-v1-database
Region: UK South
Username: see .env url Id
Database pswd = see .env url Password
