using Employee_Management_System;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Employee Management System (EF Core) ===");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddEmployee(); break;
                case "2": ViewEmployees(); break;
                case "3": SearchEmployee(); break;
                case "4": UpdateEmployee(); break;
                case "5": DeleteEmployee(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    // 🔹 Add Employee
    static void AddEmployee()
    {
        using var db = new EmployeeContext();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        Console.Write("Enter Salary: $");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        var emp = new Employee { Name = name, Department = dept, Salary = salary };
        db.Employees.Add(emp);
        db.SaveChanges();

        Console.WriteLine("Employee added successfully!");
    }

    // 🔹 View Employees
    static void ViewEmployees()
    {
        using var db = new EmployeeContext();

        var employees = db.Employees.ToList();
        if (employees.Count == 0)
        {
            Console.WriteLine("⚠️ No employees found.");
            return;
        }

        Console.WriteLine("\n--- Employee List ---");
        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary:C}");
        }
    }

    // 🔹 Search by ID
    static void SearchEmployee()
    {
        using var db = new EmployeeContext();

        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var emp = db.Employees.Find(id);
        if (emp == null)
            Console.WriteLine("Employee not found!");
        else
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary:C}");
    }

    // 🔹 Update Employee
    static void UpdateEmployee()
    {
        using var db = new EmployeeContext();

        Console.Write("Enter Employee ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var emp = db.Employees.Find(id);
        if (emp == null)
        {
            Console.WriteLine("Employee not found!");
            return;
        }

        Console.Write($"Enter new Name (current: {emp.Name}): ");
        string name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name)) emp.Name = name;

        Console.Write($"Enter new Department (current: {emp.Department}): ");
        string dept = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(dept)) emp.Department = dept;

        Console.Write($"Enter new Salary (current: {emp.Salary}): ");
        string salary = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(salary)) emp.Salary = Convert.ToDecimal(salary);

        db.SaveChanges();
        Console.WriteLine("✅ Employee updated successfully!");
    }

    // 🔹 Delete Employee
    static void DeleteEmployee()
    {
        using var db = new EmployeeContext();

        Console.Write("Enter Employee ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var emp = db.Employees.Find(id);
        if (emp == null)
        {
            Console.WriteLine("Employee not found!");
            return;
        }

        db.Employees.Remove(emp);
        db.SaveChanges();
        Console.WriteLine("❌ Employee deleted successfully!");
    }
}
