# TestSkedgeApi
.Net 7.0 client to test skedgeApi

This project is a minimalist test client to communicate with the SKEDGE API. It can be used as a starting project for a larger one or just to be used as an example case.

The program will :
  - get and display the list of organisms of the authentificated user
  - get and display the list of entities of the first organism of the previous list
  - get and display the details of the first entity of the previous list
  - get and display the list of exercises of the first organism of the first list

**REQUIREMENTS :**
This test project is working in .NET 7.0 and is designed to test the API of the application SKEDGE.
To use it correctly you need to have the SKEDGE server URL and port and an organism level account with the following permissions:
  - Access to the Management of organizations
  - Access to the Management of exercises
  - Access to the SKEDGE API

**SETUP :**
You will need to replace the url and port of the server and to change the password and username with your own in the program.cs.
Then you will be able to start the project and to see the output of the main method which will test the API methods one by one.

**ARCHITECTURE :** 
This minimalist project contains a program.cs that perform two actions:
  - it connect to the SKEDGE API and get an authentification token from a provided username and password
  - it uses this token to test the API methods and display their response
    
It also contain a DTOs folder which contains the needed DTOs to deserialize the responses of the API (It is recommanded to add these DTOs to your own project if you want to communicate with the API)

