# Harry Potter's Closet API

Little playground for learning a bunch of things, namely:

 - Getting more comfortable with Docker and using VSCode Dev Containers for development
 - Learning my first bits of C#!
 - SQL Server
 - Building a GraphQL API


Inspiration from:
- [`mahi` article series on Medium](https://medium.com/swlh/building-a-dev-container-for-net-core-e43a2236504f) by [@ManfredLange](https://github.com/ManfredLange)
- [FreeCodeCamp .NET REST API Tutorial](https://www.youtube.com/watch?v=ZXdFisA_hOY)

Next steps:
- Switch out in memory repository for SQL Server
- Add a GraphQL endpoint
- Perhaps also create a CosmosDB version?

## Setup

You will need:
- A stable version of Visual Studio Code, with the `Remote Development` and `Docker` extensions installed
- Docker Desktop (MacOS and Windows) or Docker Engine (Linux)

In a terminal, run:
```sh
git clone git@github.com:lache-melvin/harry-potter-api.git
# OR
git clone https://github.com/lache-melvin/harry-potter-api.git

cd harry-potter-api

# Open the repository in VSCode
code .
```

- In VSCode, when the prompt appears, select `Reopen in Container`
- Wait for everything to install, then hit `F5` to launch the debugger
- You may get an error about certificates... in which case, run `dotnet dev-certs https` in a terminal instance inside VSCode. Then try launching the debugger again.
- Navigate to `https://localhost:5001/swagger`
