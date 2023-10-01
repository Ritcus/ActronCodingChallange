# ActronCodingChallange
### INSTALLTION AND RUNNING PROCESS ###

-Clone the repository from Visual Studio 2022.

-Run the project from the Visual Studio.

### API PUBLICATION ###
The API is published in Azure App Services please use this domain to navigate:
[actroncodingapi.azurewebsites.net](https://actroncodingapi.azurewebsites.net/)

and use this public API address to use the service:
https://actroncodingapi.azurewebsites.net/api/Challange/calculateLargestNumber

Note:
- The API takes an array of integers with a minimum index of 1 and returns the result as a string.
- Recommended: To use POSTMAN. Use POST to send the data as a raw body in JSON.


### PROJECTS DESCRIPTION ###

This repository includes two projects 
- a single web API implementation with an HTTP Post request that takes an array of integers and returns a string after
the calculation.

- a test project which tests only the core logic of the calculation.

### FOLDER STRUCTURE ###:

1. ActronCodingChallange:
   
-Program.cs: Middleware and pipeline for the web API, created by default projects, customized for enabling dependency injection for the RepositoryServices.

-Interface: Methods to be implemented.

-Services: An extra layer of abstraction.

-Controllers: The main API of the project.


2. ActronCodingChallangeTests:
   
- ServicesTests: Service layer test cases.
