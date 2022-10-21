# MediatR-based NeerCore project template

## Project Hierarchy

> `MiddleTemplate.Api` \
>> `MiddleTemplate.Infrastructure` \
>>> `MiddleTemplate.Application` \
>>>> `MiddleTemplate.Data.Sqlite`

## Project Structure

- `MiddleTemplate.Api`
    - ASP.NET REST API
    - Controllers
    - API Configuration
- `MiddleTemplate.Application`
    - Mediator features
    - Mapster mappings
    - Application models
    - Service abstractions
- `MiddleTemplate.Data.Sqlite`
    - EF Core DB
    - Entities
    - EF Migrations
- `MiddleTemplate.Infrastructure`
    - Service implementations