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

