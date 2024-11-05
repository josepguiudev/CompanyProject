# CompanyProject
In this project we are going to make a quick overview of how to connect applications with different languages to an api and from there communicate with a database.

## First steps to follow: 
### - We will use mysql as data manager where we will create a table for users
### - We will use .NET 8 to create the api in c#.
### - We will use a small program in c# to manage users

## How to install [.Net SDK](https://dotnet.microsoft.com/es-es/download)
- cmd dotnet new webapi -n MiApiCompany
- cmd cd MiApiCompany

Now try to run it:
- cmd dotnet run

## Packages to download
- Microsoft.EntityFrameworkCore.MySql: This package is required to work with MySQL. --> dotnet add package Microsoft.EntityFrameworkCore.MySql
- Microsoft.EntityFrameworkCore.Tools: Provides tools for migrations and other operations related to EF Core. --> dotnet add package Microsoft.EntityFrameworkCore.Tools
