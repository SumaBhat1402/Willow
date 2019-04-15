# Willow
Willow Coding Challenge
Q1 - Solved -available under Q1.Closure folder.
Q2 - Solved - available under Q2.SqlQuery folder.

Q3-WebApplication
Open folder : JobApplication
Open the solution in Visual studio 2015/2017 and run. 
URL:http://localhost:{PORTNUMBER}/api/Floor
Ex:http://localhost:51002/api/Floor

Q4 -WebApi
Folder:JobApi
Open the solution in VS 2015/2017 and run.
URL:http://localhost:{PORTNUMBER}/job/Index


Technical Details:
Developed in Visual studio 2015.
Entity Framework database first approach. and DBContext used for db connection.
Dependency  Injection:
Ninject - Config file to register the types -NinjectWebcommon.cs
Unit Testing:
VisualStudio unit testing and NSubstitute for Mock.

On click of Update button, it updates to db and button will be disabled.
Note:Job 1 and 5 are used to test update to db and hence they show  Completed status.
