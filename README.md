# MVCCourse

A small ASP.NET Core MVC sample application demonstrating a simple CRUD website for managing categories. This project is designed as a portfolio piece to showcase practical knowledge of ASP.NET Core MVC, Entity Framework Core, server-side rendering with Razor views, and database migrations.

**Key highlights**
- **Full MVC stack:** Controllers, Views (Razor), Models.
- **Data persistence:** Entity Framework Core migrations and a SQL Server database.
- **CRUD UI:** Create, Read, Update, Delete operations for `Category` entities with server-side validation.
- **Clean structure:** Organized folders for `Controllers`, `Models`, `Data`, and `Views` to demonstrate real-world conventions.

**Demo / What you can do**
- View a list of categories and their details.
- Add new categories and edit or delete existing ones.
- See server-side validation and friendly UI using Bootstrap (via `wwwroot/lib/bootstrap`).

**Features**
- Category management (list, add, edit, delete).
- EF Core code-first migrations included under the `Migrations` folder.
- Simple, readable Razor views that a hiring manager can review quickly.

**Tech stack**
- ASP.NET Core MVC (Razor Views)
- Entity Framework Core (Code-First Migrations)
- SQL Server (connection configured in `appsettings.json`)
- Bootstrap for basic styling

**Project structure (selected files)**
- `Program.cs` - app startup and host configuration.
- `Data/ApplicationDbContext.cs` - EF Core DbContext and model registrations.
- `Models/Category.cs` - `Category` entity model.
- `Controllers/CategoriesController.cs` - MVC controller implementing CRUD.
- `Views/Categories/` - Razor views for the category pages.
- `Migrations/` - EF Core migrations used to create the database schema.

**Getting started (local development)**
Prerequisites:
- .NET SDK (matching the project target, e.g. .NET 10)
- A SQL Server instance accessible from your machine (the default connection string uses SQL Express).

Quick steps:
1. Open a terminal and change to the project folder:

```bash
cd MVCCourse
```

2. Update the connection string in `appsettings.json` to point to your SQL Server instance. The current key is `ConnectionStrings:DefaultConnection`.

3. (Optional) Install the EF Core tools if you need them locally:

```bash
dotnet tool install --global dotnet-ef
```

4. Apply migrations to create the database:

```bash
dotnet ef database update
```

5. Run the application:

```bash
dotnet run
```

6. Navigate to `https://localhost:5001` (or the URL shown in the console) and open the Categories section to exercise the CRUD UI.

**Notes on database**
- This project ships with an EF Core migration set in the `Migrations` folder. The default connection in `MVCCourse/appsettings.json` points to a SQL Server Express instance; you can replace it with LocalDB, a full SQL Server, or an Azure SQL connection string for deployment.

**How this helps in interviews**
- The codebase demonstrates common patterns: separation of concerns, model validation, use of EF Core migrations, and simple UI using Razor and Bootstrap. You can discuss trade-offs (client vs server rendering, validation strategies, DI, and testability) and extend it with authentication, API endpoints, or richer data models during interviews.

**Next steps / suggestions**
- Add unit and integration tests for controllers and data layer.
- Add authentication and role-based authorization.
- Add API endpoints with JSON responses and client-side SPA integration.

**Contact / Attribution**
If you want me to help tailor this README further for a specific job application or to add screenshots and sample data, let me know.
