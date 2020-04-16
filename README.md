# _C# Building an API_

#### _04.3.2020_

#### By _**Jose Amesquita**_

## Description

_This C# web application is design to help a local Animal Shelter that will list available cats and dogs to the community by building an API (Application Programming Interface). The purpose of this application is to demonstrate full CRUD functionality, JWT Authentication with complete documentation of API endpoints. This application will allow the user to create an account through the website and be able to login into their account to navigate through the Animal Shelter site. Hope you enjoy!_

## Specs

* A user will be able to view a full list of animal(s) in the Animal Shelter from the Animal database (API)
* A user will be able to add new animal(s) to the Animals database (API)
* A user will be able to edit animal(s) from the Animals database (API)
* A user will be able to delete animal(s) from the Animals database (API)

## API Endpoints 

Animals 

* GET /api/animals
* POST /api/animals
* GET /api/animals/{id}
* PUT /api/animals/{id}
* DELETE /api/animals/{id}

## Setup/Installation Requirements

#### Retrieving code to launch API project 

1. visit https://github.com/joseamesquita/AnimalShelterAPI.git
2. click the green button: Clone or download 
3. select copy and open terminal from your desktop
4. on terminal browse to your desktop: cd Desktop
5. type: 'git clone https://github.com/joseamesquita/AnimalShelter.git'
6. type: 'code .' to view all source code on Visual Studio Code
7. within the directory on the terminal type 'dotnet restore' to run the program
8. within the directory on the terminal type 'dotnet ef database update' to run the program
9. within the directory on the terminal type 'dotnet run' to run the program
10. open a browser and copy and paste ```http://localhost:5000/ or http://localhost:5001/``` from the terminal. 
11. if you would like to application to stop running type ```Ctrl + C```

#### Installing MySQL 

1. visit MySQL Community Downloads: https://dev.mysql.com/downloads/file/?id=484914
2. select "No thanks, just start my download." at the bottom of the page
3. browse through your downloads and begin the installer
4. specify legacy password encryption 
5. set password (NOTE: inside your appsettings.json file make sure password matches the password you created)
6. select finish from the installer 
7. now go to Terminal and enter the command 'echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile'
8. you can now verify the MySQL installation going into Terminal and enter the command 'mysql -uroot -p{your password here}' and installtion will be complete. 

#### Installing MySQL Workbench 

1. visit MySQL Community Downloads and download MySQL Workbench for macOS: https://dev.mysql.com/downloads/workbench/
2. when MySQL Workbench is installed, open MySQL Workbench application and insert local server 3306 and enter your password from above

#### Accessing the Animals Database via the Terminal on macOS

1. type 'mysql -uroot -p{'your password'}
2. type 'show databases;'
3. type 'use animal_shelter;'
4. type 'select * from animals;'

## Known Bugs

_This application is under-developed and is currently improving._

## Support and contact details

_Please reach out to me if you have any questions or any concerns with this application. email: joseamesquita11@gmail.com_

## Technologies Used

* C#
* _Git_
* _VSCode_
* _MVC_
* _.NET Core 2.2_ 
* _Enitity Core Framework_
* _MySQL_
* _JWT Authentication_

### License

*This is licensed by MIT.*

Copyright (c) 2016 **_Jose Amesquita_**