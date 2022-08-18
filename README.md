# Skate Rate

#### By _**Grace Kostanich & Maxwell Alvord**_   

#### _This is an API for skate parks that includes information about their names, locations, rating, and what everyone calls the park - their nicknames!_  

---


## Technologies Used

* _C#_
* _.NET_
* _SQL Workbench_
* _Entity Framework_
* _Swagger_

---
## Description

This is an API built on ASP.NET Core MVC that's populated with seed data from imaginary skate parks.   
_Written in C#_

---
## API Documentation
_This API is using Swagger (an open-source API tool) to describe its structure and display all available endpoints_

<details>
<summary><strong>View in Browser</strong></summary>
<ol>
<li> Follow the project <strong>Setup and Installation Requirements</strong> below & run the application in a terminal inside the projects root directory with   

```$ dotnet run```
<li> Open the application in a browser by selecting the provided link in your terminal   

(Ex:|| https://localhost:5004) 

<li> Add <strong>"/swagger"</strong> to the end of the URL path to view API structure and all endpoints    

(Ex:|| https://localhost:5004/swagger)

<br>
</details>

---
## Endpoints

Base URL: https://localhost:5004

#### HTTP Request

```
GET api/Parks
POST api/Parks
DELETE api/Parks/{id}
PUT api/Parks/{id}
GET api/Parks/{id}
```

#### Example Query

```
https://localhost:5004/api/Parks/1
```

---

## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/User8240/More-swag.git
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/User8240/More-swag.git</strong>
<li>In the terminal, navigate into the projects root directory, "SkateRate".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.Development.json file in the "SkatePark" directory  
   <pre>SkatePark
   └── appsetting.json</pre>

<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=skate_park;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.Development.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "SkatePark", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "skate_park" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the table, you should see <strong>parks</strong>.
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>SkatePark/</pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---

>#### _**A Big Thanks To:**_ 
>#### **Garrett Hays @ https://github.com/GarrettHays**    
>#### **Zachary Waggoner @ https://github.com/CyndaZ42**  
>#### _**for amazing README formatting and instructions!**_  

---

## Known Bugs

* _No known issues_

## License

_None_


Copyright (c) 8/18/2022 Grace Kostanich & Maxwell Alvord