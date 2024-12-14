# NorthwindMVC Project

This project is a web application built using ASP.NET Core MVC. It follows a layered architecture with support for **CRUD operations** for entities such as Categories, Customers, Orders, and Products. The project also includes a dashboard for better visualization.

## Project Overview

### Features
- **CRUD Operations** for:
    - Categories
    - Customers
    - Orders
    - Products
- **View Models** for better data management between the UI and backend.
- Organized architecture for better scalability and maintainability.
- Razor views for displaying and managing data.

## Directory Structure

```
NorthwindMVC/
├── Dependencies/
├── Properties/
├── wwwroot/
├── Controllers/
│   ├── Category/
│   │   └── CategoryController.cs
│   ├── Customer/
│   │   └── CustomerController.cs
│   ├── Dashboard/
│   │   └── DashboardController.cs
│   ├── Order/
│   │   └── OrderController.cs
│   ├── Product/
│   │   ├── ProductController.cs
│   │   └── IController.cs
├── Models/
│   ├── Contexts/
│   │   └── NorthwindContext.cs
│   ├── DTOs/
│   │   ├── Category/
│   │   │   └── CategoryDto.cs
│   │   ├── Customer/
│   │   │   └── CustomerDto.cs
│   │   └── Product/
│   │       └── ProductDto.cs
│   ├── Entities/
│   │   ├── Category/
│   │   │   ├── Category.cs
│   │   │   └── CategoryViewModel.cs
│   │   ├── Customer/
│   │   │   ├── Customer.cs
│   │   │   └── CustomerViewModel.cs
│   │   ├── Dashboard/
│   │   │   └── DashboardViewModel.cs
│   │   ├── Order/
│   │   │   ├── Order.cs
│   │   │   └── OrderViewModel.cs
│   │   ├── Product/
│   │   │   ├── Product.cs
│   │   │   └── ProductViewModel.cs
│   │   └── ErrorViewModel.cs
├── Views/
│   ├── Category/
│   │   ├── Add.cshtml
│   │   └── Index.cshtml
│   ├── Customer/
│   │   ├── Add.cshtml
│   │   └── Index.cshtml
│   ├── Dashboard/
│   │   └── Index.cshtml
│   ├── Order/
│   │   └── Index.cshtml
│   ├── Product/
│   │   ├── Add.cshtml
│   │   └── Index.cshtml
│   └── Shared/
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── README.md
└── Scratches and Consoles/
```

## Prerequisites

1. **.NET 7 SDK**
2. **SQL Server**

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/northwindmvc.git
   cd northwindmvc
   ```

2. Configure the database connection in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "SqlServer": "Server=localhost,1433;Database=Northwind;User Id=sa;Password=yourpassword;Encrypt=False;TrustServerCertificate=True"
   }
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Apply migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open the application in your browser:
    - Default URL: `https://localhost:5001` (for HTTPS) or `http://localhost:5000` (for HTTP).

## API Endpoints (Optional)

### Categories
- **GET** `/api/categories`
- **POST** `/api/categories`

### Customers
- **GET** `/api/customers`
- **POST** `/api/customers`

### Products
- **GET** `/api/products`
- **POST** `/api/products`

