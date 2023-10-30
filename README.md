# ASP.NET-website
## Acme Corporation - Users can enter a draw for a prize.

This website is created using ASP.NET in Visual Studio's solutions - AcmeCorporation. 
There are three projects in the solution: `AcmeCorporationWebsite`, `AcmeCorporationLibrary` and `AcmeCorporationUnitTests`

AcmeCorporationWebsite (ASP.NET Web Application Project):
> - Views
> - Controllers
> - Scripts: JavaScript files
> - Styles: CSS files

AcmeCorporationLibrary (Class Library Project):
> - DataAccess
> - BusinessLogic
> - Models
> - Utilities

AcmeCorporationUnitTests (Testing Project):
> - UnitTests

The landing page is for an international company called “Acme Corporation” where users can enter a draw for a prize. 

A user can enter the draw if they have a valid serial number from purchasing one of Acme Corporation’s products. 
The valid serial number can be used twice in the draw and the user must be at least 18 years old.

They enter the draw by Form submission:

▪ First name

▪ Last name

▪ Email address

▪ Product serial number

## Connecting to the MSSQL db
Inside `appsettings.json` there is the default login. No username or password needed.
```JSON
  "ConnectionStrings": {
    "DefaultConnection": "Server=LAPTOP-AV3K8LV5;Database=AcmeCorp;Trusted_Connection=True;"
```
There are already 100 valid serial numbers generated.