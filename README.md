# btTemplate
btTemplate is a full-stack application that includes a React client and a .NET server. The client is built with Vite and React, and the server is built with ASP.NET.

## Getting Started

To get started with btTemplate, clone the repository and install the necessary dependencies.

For the client, run the following commands:
```sh
cd btTemplete/bttemplete.client
npm install
npm run dev
```
For the server, run the following commands:
```sh
cd btTemplete/btTemplete.Server
dotnet restore
dotnet run
```
## Usage
- To use btTemplete, open your browser to https://localhost:5173/

- To stop the application, use `Ctrl+C` in the terminal.

## Release Notes
In this submission, the following features are working:

The frontend contains a form that will send a few data fields to the back end.
The backend will take these fields and return some simple html representing a handlebars template filled with the data
passed from the frontend.
The frontend will then display this html.

## Additional Branches
All relevant code is contained in the main branch for now.
