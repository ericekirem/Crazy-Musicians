# Crazy Musicians API

**Crazy Musicians API** is an ASP.NET Core Web API that allows users to manage musicians and their music-related information. The API supports basic CRUD (Create, Read, Update, Delete) operations and includes search functionality based on musician names.

This project demonstrates the usage of ASP.NET Core to create a RESTful API with routing, validation, and different types of HTTP methods like `GET`, `POST`, `PUT`, `PATCH`, and `DELETE`.

## Features

- **GET** `/api/musician`: Retrieves a list of all musicians.
- **GET** `/api/musician/{id}`: Retrieves a specific musician by ID.
- **POST** `/api/musician`: Adds a new musician.
- **PUT** `/api/musician/{id}`: Updates an existing musician.
- **PATCH** `/api/musician/{id}`: Partially updates a musician's information.
- **DELETE** `/api/musician/{id}`: Deletes a musician.
- **GET** `/api/musician/search`: Allows search by musician's name.

## Project Setup

### Prerequisites

To run this project, ensure you have the following installed:

- [.NET 6.0 or later](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)
- A browser for testing the API
