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

To use the repo 
### need in visual studio Package Manager Console run updata-database to setup the local sqllite database and tables
In the home page is used to generate the mock data to backend
1. click Send button will send one record data to backend.
2. Before click send button, you can change the data in the page.
3. Click Send data every 5 seconds button will send data every 5 seconds util the value of "Repeat send data times" count to 0.
4. You can chang send how many data.
5. Click Send button will send the data according the value of pages.
6. Click Send data every 5 seconds button will send the time value and a random number rang 0 to 10.
7. click Report, will show the report
