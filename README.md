# CompanyProject
In this project we are going to make a quick overview of how to connect applications with different languages to an api and from there communicate with a database.

<div style="display: flex; justify-content: center; align-items: center;" width="100%">
    <img src="images/login.jpg" alt="Logo del Proyecto" width="auto" height="200px" style="margin-right: 50px;">
    <img src="images/crud.jpg" alt="Logo del Proyecto" width="auto" height="200px" style="margin-right: 50px;">
    <img src="images/crud2.jpg" alt="Logo del Proyecto" width="auto" height="200px">
</div>

# MySQL
Table

<div style="display: flex; justify-content: center; align-items: center;" width="100%">
    <img src="images/tabla.jpg" alt="Logo del Proyecto" width="auto" height="200px" style="margin-right: 50px;">
</div>

# API

<div style="display: flex; justify-content: center; align-items: center;" width="100%">
    <img src="images/swag.jpg" alt="Logo del Proyecto" width="auto" height="200px" style="margin-right: 50px;">
</div>

## First steps to follow: 
### - We will use mysql as data manager where we will create a table for users
### - We will use .NET 8 to create the api in c#.
### - We will use a small program in c# to manage users

## Why use ASP.NET
ADVANTAGES:
- Multiplatform: Works on Windows, Linux and macOS.
- High performance: It is known for its high performance and scalability.
- HTTP request handling: It is ideal for building services that handle HTTP requests, such as RESTful APIs.
- Database integration: You can use Entity Framework Core to connect your API to SQL or NoSQL databases easily.

## How to install [.Net SDK](https://dotnet.microsoft.com/es-es/download)
- cmd dotnet new webapi -n MiApiCompany
- cmd cd MiApiCompany

Now try to run it:
- cmd dotnet run --> Now go to htp://localhost:5277/tswagger/index.html OR htp://localhost:5277/api/usuarios must load data

## Packages to download
- Microsoft.EntityFrameworkCore.MySql: This package is required to work with MySQL. --> dotnet add package Microsoft.EntityFrameworkCore.MySql
- Microsoft.EntityFrameworkCore.Tools: Provides tools for migrations and other operations related to EF Core. --> dotnet add package Microsoft.EntityFrameworkCore.Tools
- For my desktop application I will use c# and we will have to download the newtonsoft for communication with the api --> dotnet add package Newtonsoft.Json
- Note that if you want to make a copy of your database to a .sql file you can use --> mysqldump -u username -p database_name > backup_file.sql OR mysqldump -u root -p mi_base_de_datos > mi_base_de_datos_backup.sql :D
