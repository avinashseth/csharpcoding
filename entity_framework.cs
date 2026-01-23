dotnet tool install --global dotnet-ef
*************************************
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.2
*************************************
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.2
*************************************
dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.2
*************************************
Run the following commands
dotnet restore
dotnet build
*************************************
Run the migration
dotnet ef migrations add InitialCreate
dotnet ef database update
*************************************


*************************************
Add following packages
*************************************
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
*************************************
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
*************************************
dotnet add package Microsoft.EntityFrameworkCore.Tools
*************************************
Run Following Commands
*************************************
dotnet ef migrations add Init
*************************************
dotnet ef database update
*************************************

