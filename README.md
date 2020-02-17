# PeopleDirectory

On initial pull dont forget to run Migrations
Add-Migration
Update-Database

Create a 'People Directory' application that has 2 parts.
  1. Client section
  2. Admin Section

CLIENT SECTION
  Description
  The Client section should allow you to search the people directory for a person to:
     View their Contact details
     View their Personal information
      o with a Country filter
      o with a City filter
      o Anything else… being a test scenario feel free to impress!
  Requirements
  1. Feel free to present the Frontend UI using any HTML5 free templates or your own
  HTML/CSS.
  2. Create a Client Frontend UI that has a Predictive text search input on First Name or
  Surname only.
  3. Make use of a REST service to complete the predictive text lookup
  4. Once a desired name or surname is found, all results should output to a table/grid
  (catering for the Name or Surname) that shows only a data summary
  5. The results hyperlink to view the persons full information:
    o Name
    o Surname
    o Address (country and city)
    o Profile pic
    o Mobile number
    o Gender
    o Email address
    o Anything else you wish to include…
    
ADMIN SECTION
  Description
  The Admin section allows an administrator to manage the people database.
  Requirements
    1. Provide a login mechanism for the Admin section
    2. Allow the administrator to manage the people Db - CRUD
    3. When entering the city and country, allow the admin to choose a country from a
    dropdown list and prepopulate the city dropdown based on the country chosen
    4. Once a person's info is edited, send a confirmation email for that particular user
    saying what was edited and what the new values are to: mark@bluegrassdigital.com
    Technical Requirements
  
Patterns to be used:
   MVC
   Repository
   Dependency Injection
  
Technology to be used:
   C# / .Net 4.5 MVC or above
   Entity Framework 6 or above - Please use the code first approach and not the EDMX
model
   .Net Web API (for REST call)
   AJAX if possible
