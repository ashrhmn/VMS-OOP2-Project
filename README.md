# VMS - Vote Management System

## A project for the final term exam of the course OOP2 in AIUB

### Visual Studio 2019 Project
#### MSSQL in backend

## Voting Management System

Voting Management System is a paperless documentary application or system used for voting a character in any type of election. The population of Bangladesh is spread throughout its districts. Everyone has to be counted in this voting system and managing their votes in a paper or ballot system is time-consuming. The Voting Management System is a modern and innovative project. If we looked into other developed countries, they have already moved away from the ballot system years ago. The main advantage of the application is that the same app can be divided into all the districts and they can submit their own voting data and data from all the districts is merged to show a complete result. It aims to improve efficiency in collecting votes and reducing the complexity involved in merging data from all the districts and showing a complete result.

To run the program on your system, clone the repo. Open the project in Visual Studio and change the -connectionString variable in [DBConnection.cs](https://github.com/ashrhmn/VMS-OOP2-Project/blob/eb8bb1a63556fb1a90a923c04c33bb38c82e129f/VMS/Repository/DBConnection.cs#L11)

### **Requirement Analysis**

**1.User Category** :
There are 3 types of users here, They are -
* Admin
* District Manager
* General Public

**2. Feature List** :
* In this project the **Admin** has the following features:
  * [x] Login
  * [x] Add new **Admin**
  * [x] Assign a **GeneralPublic** as **District Manager**
  * [x] View data ~~for all district~~
  * [x] View Total Result
  * [x] Manage total list of **General Public** with ~~NID and~~ their details
  * [x] Approve applied new accounts and assign NID to the new accounts
* In this project **District Manager** has the following features:
  * [x] Login
  * [x] Assign a **General Public** as Candidate for Election
  * [x] View Data ~~for assigned district~~
  * [x] View result ~~for assigned district~~
* In this project the **General Public** has the following features:
  * [x] Login
  * [x] ~~Create~~ Apply for Account ~~(with NID must be included in the **NID Database** that **Admin** manages)~~
  * [x] Vote any of the Candidates

*Had to remove NID assignment and District wise Voting*
