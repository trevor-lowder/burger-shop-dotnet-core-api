# BigEBurgers CRUD API

A .NET Core Web Framework-based API for managing burger-related data for BigEBurgers, a fictional burger shop.

## Features

- **Create:** Add new burgers to the menu.
- **Read:** Retrieve information about existing burgers.
- **Update:** Modify details of existing burgers.
- **Delete:** Remove burgers from the menu.

## Getting Started
Clone the repository:

```bash
git clone https://github.com/your-username/BigEBurgers-CRUD-API.git
```
Navigate to the project directory:
```bash
cd BigEBurgers-CRUD-API
```

Build and run the application:
```bash
dotnet build
dotnet run
```

The API will be accessible at http://localhost:8080.

## Usage
### Endpoints
- GET /burgers: Retrieve a list of all burgers.
- GET /burgers/{id}: Retrieve details of a specific burger.
- POST /burgers: Add a new burger to the menu.
- PUT /burgers/{id}: Update details of a specific burger.
- DELETE /burgers/{id}: Remove a burger from the menu.
