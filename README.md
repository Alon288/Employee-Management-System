# 🏢 Employee Management System (Console App + EF Core)

## 📖 Project Overview
A **C# .NET Console Application** for managing employee records with **SQL Server** as the database and **Entity Framework Core (EF Core)** for ORM.  
This project demonstrates **OOP, CRUD operations, EF Core migrations, and clean architecture** — great for learning and for interview portfolios.  

---

## ✨ Features
- ➕ **Add Employee** → Insert employee with auto-generated ID.  
- 📋 **View Employees** → Fetch all employees from SQL Server.  
- 🔍 **Search Employee by ID** → Find employee details.  
- ✏️ **Update Employee** → Modify employee details (Name, Department, Salary).  
- ❌ **Delete Employee** → Remove an employee by ID.  
- 💾 **EF Core + SQL Server** → Database-first approach with migrations.  

---

## 🛠️ Tech Stack
- **Language:** C#  
- **Framework:** .NET 6 / .NET 7 / .NET 8 Console App  
- **Database:** SQL Server  
- **ORM:** Entity Framework Core  
- **Packages:**  
  - `Microsoft.EntityFrameworkCore`  
  - `Microsoft.EntityFrameworkCore.SqlServer`  
  - `Microsoft.EntityFrameworkCore.Tools`  

---

## 🚀 How to Run

### 🔹 1. Clone the Repository
```bash
git clone https://github.com/Alon288/employee-management-system.git
cd employee-management-system
```
### 🔹 2. Install Dependencies
**If using Package Manager Console (Visual Studio):**
  -`Install-Package Microsoft.EntityFrameworkCore`
  -`Install-Package Microsoft.EntityFrameworkCore.SqlServer`
  -`Install-Package Microsoft.EntityFrameworkCore.Tools`
  
**Or via .NET CLI:**
  - `dotnet add package Microsoft.EntityFrameworkCore`
  -`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
  -`dotnet add package Microsoft.EntityFrameworkCore.Tools`

### 🔹 3. Configure Database:
Update your connection string inside EmployeeContext.cs:
`protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(
        "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;");
}
`
### 🔹 4. Apply Migrations:
**Run in Package Manager Console:**
  ```powershell
  Add-Migration InitialCreate
  Update-Database

**Or via .NET CLI:**
dotnet ef migrations add InitialCreate
dotnet ef database update

### 🔹 5. Run the App:
`dotnet run`

## 📂 Project Structure
```bash
├── Employee.cs           # Employee model (POCO class)
├── EmployeeContext.cs    # EF Core DbContext
├── Program.cs            # Main program with CRUD logic
├── Migrations/           # Auto-generated EF Core migrations
├── EmployeeDB (SQL)      # Database (auto-created by EF Core)
├── README.md             # Documentation
```

## 🖥️ Sample Usage
=== Employee Management System (EF Core) ===
1. Add Employee
2. View Employees
3. Search Employee by ID
4. Update Employee
5. Delete Employee
6. Exit
Choose an option: 1
Enter Name: Ayesha
Enter Department: IT
Enter Salary: 60000
✅ Employee added successfully!

Choose an option: 2
--- Employee List ---
ID: 1, Name: Ayesha, Dept: IT, Salary: $60,000.00

## 🎯 Learning Objectives
  - Learn Entity Framework Core (EF Core) with SQL Server.
  - Understand DbContext, DbSet, and Migrations.
  - Practice CRUD operations using LINQ.
  - Showcase Clean Code + ORM skills for interviews.

## 👨‍💻 Author
Developed by Syed Najeeb Ahmed (Github: Alon288) 👋






