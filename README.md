# LapGenerator
This a test demo project.

I use these steps to setup this project.
1. In Visual Studio 2022 create a MVC project
2. In Visual Studio Git create a repo in github
3. In Package Manager Console 
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools

4. In Model folder: 
   create DbContext and Models 
  (Using SqlLite, so set the directory in Mydocument)
5. In Package Manager Console 
   add-migration
   update-database (setup the database and tables)

6. add Api controller
7. In program.cs config DbContext
8. using postman test api add some data.
9. add index page
10. add report page
