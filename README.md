# ASP.NET 6 CQRS REST-API (based on NeerCore)

## Getting started

Execute the following command in your terminal to run the app: \
`dotnet run --project MiddleTemplate.Api`

Open Swagger Docs: https://localhost:7000/swagger/index.html

## Migrate a Database

Create migration with following command: \
`dotnet ef migrations add <MigrationName> -p MiddleTemplate.Data.Sqlite`

Apply migrations on database: \
`dotnet ef database update`

## Additional information

### Feature list

- Swagger UI
- API Versioning
- Global Exception Handler
- CQRS pattern (using MediatR)
- Model mapping (using Mapster)
- Logging (using NLog)
- Entity Framework Core
- DB Migrations
- Sorting&Filtering (using Sieve)
