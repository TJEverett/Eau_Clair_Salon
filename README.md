# Eau Clair's Salon

#### _Track Stylists and Their Clients, 01/26/2021_

#### By _**Tristen Everett**_

## Description

This project was an attempt at showing the skills I learned to program in C#. In this project I built a ASP.NET MVC webapp that allows the user to create stylists to a database, then create clients and have them belong to a specific stylist to demonstrate understanding of one to many relationships within a database. The user will be able to navigate between multiple pages to view who is already in the database, add someone to the database, or see details about a stylist and see which clients belong to that stylist.

## Setup/Installation Requirements

1. Clone this Repo
2. Launch MYSQL Workbench
3. Open *Administration* window from MYSQL Workbench under *Navigator*
4. Select *Data Import/Restore*
5. Select *Import from Self-Contained File*
6. Use the tristen_everett.sql file that came with the repo
7. Under *Default Schema to be Imported To* select the *New* button and enter the name tristen_everett and select it from the pull down list
8. Click *Start Import*
9. You may need to update file /HairSalon/appsettings.json to match the userID and password for the computer your using
10. Run `dotnet restore` from within the /HairSalon file location
11. Run `dotnet build` from within the /HairSalon file location
12. Run `dotnet run` from within the /HairSalon file location
13. Using your preferred browser navigate to http://localhost:5000/

## Technologies Used

* C#
* ASP.NET Core
* Entity Framework Core
* MYSQL
* Razor Pages

### License

This software is licensed under the MIT license

Copyright (c) 2021 **_Tristen Everett_**