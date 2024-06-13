dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore

Instal dotnet entity framework
dotnet tool install dotnet-ef --global

List dotnet tool
dotnet tool list --global

Initialize database
dotnet-ef migrations add "init database"

Create database
dotnet-ef database update
