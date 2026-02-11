using System;
using System.Xml.Linq;

namespace Csharp.Day6
{



    #region problem 1
    //public struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y; 
    //    }

    //    public override string ToString()
    //    {
    //        return $"{X} and {Y}";
    //    }
    //}
    #endregion

    #region problm 3
    //struct Employee
    //{
    //    // Private attributes
    //    private int EmpId;
    //    private string Name;
    //    private double Salary;

    // Constructor
    //public Employee(int empId, string name, double salary)
    //{
    //    EmpId = empId;
    //    Name = name;
    //    Salary = salary;
    //}

    //// Methods for Name
    //public string GetName()
    //{
    //    return Name;
    //}

    //public void SetName(string name)
    //{
    //    if (!string.IsNullOrEmpty(name))
    //        Name = name;
    //    else
    //        Console.WriteLine("Invalid Name!");
    //}

    //// Property for Salary
    //public double EmployeeSalary
    //{
    //    get { return Salary; }
    //    set
    //    {
    //        if (value >= 0)
    //            Salary = value;
    //            else
    //                Console.WriteLine("Salary cannot be negative!");
    //        }
    //    }

    //    // Property for EmpId (read-only)
    //    public int EmployeeId
    //    {
    //        get { return EmpId; }
    //    }

    //    // Method to print Employee info
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
    //    }
    //}
    #endregion

    #region problem 4
    //struct Point
    //{
    //    public int X;
    //    public int Y;

    //    // Constructor 1: Initialize X, Y = 0
    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    // Constructor 2: Initialize X and Y
    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    // Method to display point
    //    public void Display()
    //    {
    //        Console.WriteLine($"Point: X = {X}, Y = {Y}");
    //    }
    #endregion

    #region problem 5
    //struct Point
    //{
    //    public int X;
    //    public int Y;

    //    // Constructor 1: X only
    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    // Constructor 2: X and Y
    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    // Override ToString for custom formatting
    //    public override string ToString()
    //    {
    //        return $"[Point -> X: {X}, Y: {Y}]";
    //    }
    #endregion

   






        internal class Program

        {
            static void Main()

            {
            #region problm 1
            //Point p1 = new Point(12,8);
            //Point p2 = new Point();
            //Console.WriteLine(p1);  // 12 and 8
            //Console.WriteLine(p2);  // 0 and 0

            //  Question: Why can't a struct inherit from another struct or class in C#? 
            // because the struct stord in the stack as a value type 

            #endregion

            #region problem 2
            //TypeA obj = new TypeA();
            ////Console.WriteLine(obj.F);   // error
            //Console.WriteLine(obj.G); // 20   
            //Console.WriteLine(obj.H);   // 30 
            //Console.WriteLine(obj.GetF()); // 10


            //  q :: 
            // private: accessible only in the class
            // internal: accessible in only the project
            //public: accessible in all 
            #endregion

            #region problem 3
            //// Create an Employee
            //Employee emp = new Employee(101, "Mahmoud", 5000);

            //// Accessing private data via methods and properties
            //Console.WriteLine("Original Name: " + emp.GetName());

            //emp.SetName("Ali");  // Change name
            //Console.WriteLine("Updated Name: " + emp.GetName());

            //Console.WriteLine("Original Salary: " + emp.EmployeeSalary);
            //emp.EmployeeSalary = 6000;  // Update salary
            //Console.WriteLine("Updated Salary: " + emp.EmployeeSalary);

            //// Attempt invalid salary
            //emp.EmployeeSalary = -100;  // Should give error message

            //// Display all info
            //emp.DisplayInfo();
            #endregion

            #region problem 4

            //Point p1 = new Point(5);
            //p1.Display();  // Output: X = 5, Y = 0

            //// Using second constructor
            //Point p2 = new Point(10, 20);
            //p2.Display();  // Output: X = 10, Y = 20
            #endregion

            #region problem 5
            //Point p1 = new Point(5);
            //Point p2 = new Point(10, 20);
            //Point p3 = new Point(-3, 7);

            //// Print points using ToString() implicitly
            //Console.WriteLine(p1);  // [Point -> X: 5, Y: 0]
            //Console.WriteLine(p2);  // [Point -> X: 10, Y: 20]
            //Console.WriteLine(p3);
            #endregion






        }
    }
    }
}
