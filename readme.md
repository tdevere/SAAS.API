# SaaS.Api

Welcome to the SaaS.Api project! This repository contains a .NET 9 Web API designed for SaaS applications, utilizing Docker for containerization and Entity Framework Core (EF Core) for data management.

``` Checkout ``` the [Roadmap](/roadmap.md)

## Table of Contents

- [SaaS.Api](#saasapi)
  - [Table of Contents](#table-of-contents)
  - [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
    - [Running the Application](#running-the-application)
    - [Testing the API](#testing-the-api)
  - [Development Guidelines](#development-guidelines)
    - [Adding New Models and Controllers](#adding-new-models-and-controllers)
    - [Handling Model and Controller Changes](#handling-model-and-controller-changes)
  - [Contribution Guidelines](#contribution-guidelines)
    - [Code of Conduct](#code-of-conduct)
    - [Reporting Issues](#reporting-issues)
    - [Submitting Pull Requests](#submitting-pull-requests)
    - [Community Support](#community-support)
  - [License](#license)

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [Visual Studio Code](https://code.visualstudio.com/) (recommended)
  - [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
  - [Docker Extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker)

### Installation

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/tdevere/SAAS.API/saas.api.git
   cd saas.api
   ```

2. **Restore Dependencies:**

   Open the project in Visual Studio Code and restore the required packages:

   ```bash
   dotnet restore
   ```

### Running the Application

The application is configured to run inside Docker containers using Docker Compose.

1. **Build and Start the Containers:**

   ```bash
   docker-compose up --build
   ```

   This command will:

   - Build the Docker images for the API and the PostgreSQL database.
   - Start the containers as defined in the `docker-compose.yml` file.

2. **Verify the Application is Running:**

   Once the containers are up and running, the API should be accessible at `http://localhost:5000/swagger/index.htm`.

### Testing the API

To test the API, you can use tools like [Postman](https://www.postman.com/) or simply your web browser.

**Retrieve Users:**

- Open your browser and navigate to `http://localhost:5000/swagger/index.html`.
- Try calling the GET method for Users

## Development Guidelines

### Adding New Models and Controllers

1. **Define a New Model:**

   - In the `Models` directory, create a new class that represents your entity.

2. **Create a Corresponding Controller:**

   - In the `Controllers` directory, create a new controller class.
   - Ensure it inherits from `ControllerBase` and includes the necessary CRUD actions.

3. **Update the Database Context:**

   - Add a `DbSet<TEntity>` property in the `AppDbContext` class for your new model.

4. **Generate and Apply Migrations:**

   - Open a terminal and run:

     ```bash
     dotnet ef migrations add AddYourEntity
     dotnet ef database update
     ```

   This will update the database schema to include your new entity.

### Handling Model and Controller Changes

When making changes to models or controllers:

1. **Modify the Model or Controller:**

   - Apply your changes in the respective class files.

2. **Update the Database Schema:**

   - If the changes affect the data model, generate a new migration:

     ```bash
     dotnet ef migrations add DescribeYourChange
     dotnet ef database update
     ```

   This ensures the database schema aligns with your updated models.

## Contribution Guidelines

We welcome contributions from the community! To ensure a smooth process, please follow these guidelines.

### Code of Conduct

Please adhere to our [Code of Conduct](CODE_OF_CONDUCT.md) in all interactions.

### Reporting Issues

If you encounter any issues:

- Check the [issue tracker](https://github.com/your-username/saas.api/issues) to see if it has already been reported.
- If not, create a new issue with detailed information.

### Submitting Pull Requests

To contribute code:

1. **Fork the Repository:**

   Click the "Fork" button on the repository's GitHub page.

2. **Create a New Branch:**

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make Your Changes:**

   - Follow the existing code style and conventions.
   - Ensure your code is well-documented.

4. **Commit and Push:**

   ```bash
   git commit -m "Add your descriptive commit message"
   git push origin feature/your-feature-name
   ```

5. **Open a Pull Request:**

   - Go to your forked repository on GitHub.
   - Click the "New Pull Request" button.
   - Provide a clear description of your changes.

### Community Support

For questions or discussions:

- Join our [Slack community](https://join.slack.com/your-slack-invite-link).
- Participate in [GitHub Discussions](https://github.com/your-username/saas.api/discussions).

## License

This project is licensed under the [MIT License](LICENSE).
```
