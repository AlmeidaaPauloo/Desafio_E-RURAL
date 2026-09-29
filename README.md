# CODERURAL API

> **Technical challenge from a hiring process (2022).**

REST API built with ASP.NET Core 6 to manage users, profiles and video-call rooms. Users and profiles have a many-to-many relationship; rooms store a name and a meeting link.

## Stack

- C# / ASP.NET Core 6 (Web API)
- Entity Framework Core 6 + SQL Server (LocalDB), code-first migrations
- Swagger (Swashbuckle)

## Structure

```
CODERURALAPI/
  Controllers/            Usuario, Perfil, PerfilUsuario, Sala
  Contracts/Repositories/ repository interfaces
  Data/Context/           DbContext
  Data/Mapings/           Fluent API entity mappings
  Data/Repositories/      repository implementations
  DTOs/                   request/response objects per operation
  Entidades/              domain entities
  Migrations/             EF Core migrations
```

| Controller | Operations |
|---|---|
| `Usuario` | create, list, get by id, update, delete |
| `Sala` | create, list, get by id, update, delete |
| `Perfil` | create |
| `PerfilUsuario` | link a user to a profile |

Controllers access the database only through repository interfaces, registered in `Program.cs`.

## Running locally

Requirements: .NET 6 SDK and SQL Server LocalDB (installed with Visual Studio).

```bash
dotnet tool install --global dotnet-ef
dotnet ef database update --project CODERURALAPI
dotnet run --project CODERURALAPI
```

Swagger UI is available at `/swagger` in the Development environment. The connection string is `ConnectionStrings:Default` in `appsettings.json`.

## Notes

- `VideoChamada/video-transmiss` is a Git submodule reference without a `.gitmodules` file, so its contents are not available in this repository.
- .NET 6 is out of support; an upgrade to a current LTS version would be the first step if this project is revisited.
