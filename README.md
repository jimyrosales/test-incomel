# test-incomel
Utiliza una base de datos MySql con EntityFramework
debe correr los siguientes comandos para crear la Base de Datos:
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
