# PeopleSearch
CatalystHealth Coding Exercise

Description:  

My version of the "People Search" application utilizes an ASP.NET Core MVC project to house its WebAPI and an Angular frond-end.
When the application is started, a local SQLServer database (PeopleSearchApp) will be created and seeded using the EntityFrameworkCore ORM. 
The .Net Core compontent of the applition targets the 3.0.0 framework.

The front-end (Angular) component uses Angular 8.1.2.

Running the application:

1) If you want to change the location or name of the SQLServer instance or database name the application will use, that can be configured in the appsettings.Development.json file "ServerApp" folder of your repository.
   Here is the default value:
   
 "ConnectionStrings": { "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=PeopleSearchApp;MultipleActiveResultSets=true" }
 
 2) 
 
	a. Open a PowerShell comommand prompt.
	b. Change the directory to <Git Repository directory>\SeverApp
	   default: PeopleSearch\ServerApp
	c. Excute:  dotnet run
	
3) From a brower, go to https://localhost:5001.


    
   

