# Core-Crud-Mvc
 CRUD opeeration in MVC .net 

Steps of Development of Crud( Create Read Update And Delete ) Opereation in in ASP.NET Core MVC Application From Scratch .

1) install Microsoft Mysql Server from Following Website.
 https://aka.ms/ssmsfullsetup
 
2) install visual studio 2019(Latest One) from following website.
 https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16#
 
 3) First Create database on Mysql Server .


After that start coding in visual studion

First create project in ASP.NET Core Wep Application
and Select Web Application(Model-View-Controller) Template.

1) After that You Should make a Class file on model folder Example in our Case is "NewEmpClass" for define database properties
make sure that you import ComponantModel on that file.

2) then After that Open "appsetting.json" file and add connection string on that file on top site. and you can  achive data source file from 
server explore in that make a data connection through sql server from giveing your server name in our case server name is DESKTOP-OM7GI2I 
and select database . After that your data connection is done so go to data connectioon property and copy connection string and copy it to
"appsetting.json" file on myconnection:"here"

3) then add Empty Mvc Controller in our Case controller is "EmpController" ,

4) After that Create New Class on model form inherite database context in our case this call is "ApplictionDbContext". And Import EntityFramworkCore
if you did not install that package then you can install package from tool=> nuget Package manager =>manage nuger mackage solution => Browser search here 
entityFramworkCore And install.

5)After that open Startup.cs file And add Confirecation service For DbContext.

6) Ater that make a Define index method For retrive data from database ,Create for create data on database ,Edit for Edit data on database.Details for Show Details 
of that row And last Delete method for Delete Record in Database. And make a view for Each method by Selecting that mathod click right click = >Add view => razer view=>  choose template for Each method like List,Create,Edit,Details And Delete .

7) make sure that you should change Action link from index.cshtml for buttons.

8)After that you should change controller = Emp on "Startup.cs".
After that Run Code  from  IIS Express.

ScreenShorts
![view](https://user-images.githubusercontent.com/32159491/103169863-87130700-4865-11eb-9836-3273c98586dd.png)







 
 
