# README: TestRestWebApi.csproj

# Docker and Kubernetes Deployment
For Docker and Kubernetes deployment, I have followed this guide:
[How to Easily Deploy an API with .NET Core to Kubernetes on Docker](https://medium.com/tech-blogs-by-nest-digital/how-to-easily-deploy-an-api-with-net-core-to-kubernetes-on-docker-dd2b5e978d75)

## Overview
TestRestWebApi is a RESTful API project built using .NET Core. This project serves as a backend for handling HTTP requests and providing data responses. It includes features such as data processing, and integration with external services.

---

## Project Structure
```
TestRestWebApi/
│-- Controllers/
│   │-- SampleController.cs
│-- Models/
│   │-- SampleModel.cs
│-- Services/
│   │-- SampleService.cs
│-- Middleware/
│   │-- ExceptionHandlingMiddleware.cs
│-- Program.cs
│-- appsettings.json
│-- TestRestWebApi.csproj
|-- Dockerfile
|-- deployment
    |-- TestRestWebApi.yaml
    |-- TestRestWebApi-srv.yaml
```


## Features
- **RESTful API Endpoints**: Implements standard HTTP methods (GET, POST, PUT, DELETE)
- **Dependency Injection**: Uses built-in .NET Core DI
- **Middleware Support**: Custom middleware for error handling
- **Authentication & Authorization**: JWT-based authentication (if applicable)
- **Logging & Monitoring**: Integrated with Serilog
- **Unit Testing**: Implemented test cases using xUnit and Moq

---

## Installation & Setup
### Prerequisites
- .NET 6.0 or later
- Visual Studio or VS Code
- SQL Server (if database is used)

### Steps
1. Clone the repository:
   ```sh
   git clone https://github.com/yourrepo/TestRestWebApi.git
   ```
2. Navigate to the project directory:
   ```sh
   cd TestRestWebApi
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Run the application:
   ```sh
   dotnet run
   ```

---

## API Endpoints
### Sample Endpoints
- **GET /api/sample** - Retrieves a list of sample data
- **POST /api/sample** - Creates a new sample entry
- **PUT /api/sample/{id}** - Updates an existing sample entry
- **DELETE /api/sample/{id}** - Deletes a sample entry

---

## Configuration
Modify `appsettings.json` to configure database connections, logging levels, and authentication settings.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=TestDB;User Id=sa;Password=yourpassword;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  }
}
```

---

## Unit Testing
Run the test cases using:
```sh
dotnet test
```

Tests are located in the `TestRestWebApi.Tests` project.

---

## Deployment
To publish and deploy the API:
```sh
dotnet publish -c Release -o ./publish
```
Deploy the output in `./publish` to an IIS server or containerize it using Docker.

### Docker and Kubernetes Deployment
For Docker and Kubernetes deployment, I have followed this guide:
[How to Easily Deploy an API with .NET Core to Kubernetes on Docker](https://medium.com/tech-blogs-by-nest-digital/how-to-easily-deploy-an-api-with-net-core-to-kubernetes-on-docker-dd2b5e978d75)

---

## Contributing
1. Fork the repository
2. Create a feature branch (`git checkout -b feature-branch`)
3. Commit changes (`git commit -m "Add new feature"`)
4. Push to the branch (`git push origin feature-branch`)
5. Open a Pull Request

---

## License
This project is licensed under the MIT License.

