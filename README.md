Jokes Application using ASP.NET MVC 😊🤣😂--

About 👓--
This is a jokes application using ASP.NET MVC that has features such as User login and Authentication, Implements full C.R.U.D operations and more.--

What the App Does 👓--
Anonymous Users can visit the application and read jokes but are not allowed to perform any operations on the application.--
Only Authenticated users can Create, Update and Delete jokes.--
All operations are stored in the SQL database.

Steps to Run 👓
Follow the following steps to successfully setup and run this application.

Paste your system's server name on the Connection String.

To find the connection string, open the JOKES.MVC project.
Open the solution explorer, locate the appsettings.json file at the bottom and open it.
Edit the connection string and paste your system server name in the Data Source value of the DefaultConnection key.
{
  "ConnectionString": {
    "DefaultConnection": "Server=RABBI\\SQLEXPRESS01;Database=Jokes;Trusted_Connection=True;Encrypt=False;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
Save
Run Migration e.g
    > open your Package Manager Console
    --Run the following command -
    > Add-Migration
    > Update-Database
    
Run the program
😍😍Enjoy😍😍

> Packages Installed 👓
> AutoMapper
> AutoMapper.Extensions.Microsoft.DependencyInjection
> Microsoft.EntityFrameworkCore
> Microsoft.EntityFrameworkCore.Design
> Microsoft.EntityFrameworkCore.SqlServer
> Microsoft.EntityFrameworkCore.Tools
> Microsoft.AspNetCore.Mvc.ViewFeatures
> Microsoft.AspNetCore.Http.Abstractions
> System.ComponentModel.Annotations
> Software Development Summary 👓
> Technology: C#, EF CORE & ASP.Net MVC
> Console App Framework: .NET6
> IDE: Visual Studio (Version 2022)
Paradigm or pattern of programming: Object-Oriented Programming (OOP)
