# Table of Contents

- [Introduction](#Introduction)
    - [Enter a draw for a prize](##Enter-a-draw-for-a-prize.)
- [Getting started](#Getting-started)
    - [Clone project](##Clone-project)
    - [Database setup](##Database-setup)
- [Implementation](#Implementation)
    - [Assignment](##Assignment:)
    - [Bonus](##Bonus:)
- [Structure](#Structure)
    - [AcmeCorporationLibrary (Class Library Project):](###-AcmeCorporationLibrary-(Class-Library-Project):)
    - [AcmeCorporationWebsite (ASP.NET Web Application Project):](###AcmeCorporationWebsite-(ASP.NET-Web-Application-Project):)
    - [AcmeCorporationUnitTests (Testing Project):](###AcmeCorporationUnitTests-(Testing-Project):)


# Introduction
## Enter a draw for a prize.
The landing page is for an international company called “Acme Corporation” where users can enter a draw for a prize. 

A user can enter the draw if they have a valid serial number from purchasing one of Acme Corporation’s products.


You can test the valid product serial number in the `~/ASP.NET-website/"Product serial numbers.txt"` file.


The valid product serial number can be used twice in the draw, but the user must fill out a form **and** be at least 18 years old.



# Getting started 
## Clone project
Clone via PowerShell
```PowerShell
git clone https://github.com/Flakvard/ASP.NET-website.git
```
Open path in File Explorer
```PowerShell
cd ASP.NET-website/AcmeCorporation && explorer .
```
And then open `AcmeCorporation.sln` via Visual Studio :D
## Database setup
Inside `appsettings.json` there is the default login. No username or password needed, but be sure to add the database to a working `Server=<server>`. MSSQL Management studio you can find relevant information about this.
```json
  "ConnectionStrings": {
    "DefaultConnection": "Server=LAPTOP-AV3K8LV5;Database=AcmeCorp;Trusted_Connection=True;TrustServerCertificate=True;"
```
There are already 100 valid serial numbers generated via `Add-Migration`, so you only need to `Update-Database` inside the `Package Manager Console` in Visual Studio .

# Implementation
The aim was to try an create an flexible, maintainable, and testable system that can adapt to changing requirements over time. 

This was done by:
- Defining the layers of the project
- Implementing Inversion of Control (IoC) using Dependency Injection (DI) between the layers/components.
- Try to hold SOLID principles on all levels to improve modularity and testability.
- Implements EntityFramework ORM for the Data layer/repository

There is of course other ways to do this, and I could add more abstractions layers, but I did not think it was neccesery for the assignment.

I tried my best to hold the YAGNI principles and **not** go by "ifs/maybes".

## Assignment:
- [x] Using Visual Studio
- [x] Create a web application project
- [x] Create secondary projects for
	- [x] test 
	- [x] class library content
- [x] Create database and table(s) to store information for the draw
- [x] README.md steps to get the database running locally
- [x] Generate 100 valid serial numbers
    - [x] Export the generated serial numbers for submitting ("~/Product serial numbers.txt")
- [x] Create a submission form on a web page (should include):
	- [x] First name
	- [x] Last name
	- [x] Email address
	- [x] Product serial number
    - [x] Over 18 (Yes/no) *(My addition to the form)*
- [x] Form submission data needs to be:
	- [x] validated and 
	- [x] stored in the database
    - [x] Both client-side and server-side validation on user input. *(My addition to the form)*
- [x] Create a web page showing all the form submissions
	- [x] Pagination showing 10 items per page
- [x] Write unit tests for validating the form data to ensure that the rules for entering the draw are
followed

## Bonus:
- [x] Use IoC/Dependency Injection for the solution
	- Dependency Injection into ASP.NET WebApplication pipeline builder
	    - [x] IDrawManager
	    - [x] IApplicationDbContext
- [x] Unit test for the Controller action submitting the form
	- [x] Serverside validation with invalid and valid 
	- [x] Get submissions via Async and JSON (for AJAX)
- [x] Display submissions via AJAX GET method
- [x] Write a README.md file at the root of your repository
- [ ] Require authenticated access to view the report of form submissions



# Structure

This website is created using ASP.NET in Visual Studio's solutions - AcmeCorporation. 
There are three projects in the solution: `AcmeCorporationWebsite`, `AcmeCorporationLibrary` and `AcmeCorporationUnitTests`


### AcmeCorporationLibrary (Class Library Project):
```bash
└── AcmeCorporationLibrary
    ├── AcmeCorporationLibrary.csproj
    ├── Business
    │   ├── DrawManager.cs
    │   └── IDrawManager.cs
    ├── Data
    │   ├── ApplicationDbContext.cs
    │   └── IApplicationDbContext.cs
    ├── Migrations
    │   └── ApplicationDbContextModelSnapshot.cs
    └── Models
       ├── ErrorViewModel.cs
       ├── SerialNumberModel.cs
       └── SubmissionModel.cs
```

### AcmeCorporationWebsite (ASP.NET Web Application Project):
```bash
└── AcmeCorporationWebsite
    ├── AcmeCorporationWebsite.csproj
    ├── Controllers
    │   ├── HomeController.cs
    │   └── SubmissionController.cs
    ├── Views
    │   ├── Home
    │   │   ├── Index.cshtml
    │   │   └── Privacy.cshtml
    │   ├── Shared
    │   │   ├── _Notification.cshtml
    │   │   └── _ValidationScriptsPartial.cshtml
    │   └── Submission
    │       ├── Index.cshtml
    │       └── SubmitForm.cshtml
    ├── appsettings.Development.json
    ├── appsettings.json
    └── wwwroot
        ├── css
        │   └── bootswatchTheme.css
        ├── js
        │   └── submission.js
        └── lib
            └── ...

```

### AcmeCorporationUnitTests (Testing Project):
```bash
└── AcmeCorporationUnitTests
    ├── AcmeCorporationUnitTests.csproj
    ├── Business
    │   └── DrawManagerUnitTest.cs
    ├── Controller
    │   └── SubmissionControllerUnitTest.cs
    ├── Data
    │   └── ApplicationDbContextUnitTest.cs
    ├── GlobalUsings.cs
    └── Models
        ├── SerialNumberModelUnitTest.cs
        └── SubmissionModelUnitTest.cs
```
