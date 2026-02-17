using Csharp.Day8.Interface;
using System;
using System.Drawing;
using static Csharp.Day8.Interface.ILogger;
using static Csharp.Day8.Interface.IShapeSeries;

namespace Csharp.Day8
{
    internal class Program
    {

        static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();

            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }



        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }


        static void Main()
        {
            #region problem 1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //bike.StartEngine();
            //bike.StopEngine();

            ///   Question: Why is it better to code against an interface rather than a concrete class? 
            ///   solve ;; ==> Coding against an interface reduces coupling, increases flexibility, improves testability, and follows SOLID principles. It makes the system easier to extend and maintain.

            #endregion

            #region problem 2

            // by abstract
            //Shape rect = new Rectangle(4, 5);
            //Shape circle = new Circle(3);

            //rect.Display();
            //Console.WriteLine("Rectangle Area = " + rect.GetArea());

            //circle.Display();
            //Console.WriteLine("Circle Area = " + circle.GetArea());

            // When should you prefer an abstract class over an interface?
            // Prefer an abstract class when classes share common behavior and state, and you want to provide default implementation along with enforced methods.
            #endregion

            #region problem 3
            //Product[] products =
            //{
            //     new Product(1, "Laptop", 15000),
            //     new Product(2, "Mouse", 300),
            //     new Product(3, "Keyboard", 800)
            // };

            //     Array.Sort(products);

            //     foreach (var product in products)
            //     {
            //         Console.WriteLine(product);
            //     }

            //  How does implementing IComparable improve flexibility in sorting?
            // Implementing IComparable allows a class to define its default comparison logic. This enables built-in sorting methods like Array
            #endregion

            #region problem 4
            //Student s1 = new Student(1, "Mahmoud", new Address("Cairo"));


            //Student shallowCopy = s1;


            //Student deepCopy = new Student(s1);

            //s1.Address.City = "Alex";

            //Console.WriteLine("Original:");
            //s1.Display();

            //Console.WriteLine("Shallow Copy:");
            //shallowCopy.Display();

            //Console.WriteLine("Deep Copy:");
            //deepCopy.Display();

            // What is the primary purpose of a copy constructor in C#
            // The primary purpose of a copy constructor in C# is to create a new object as a copy of an existing object, ensuring proper duplication of data and avoiding unintended reference sharing (especially in deep copy scenarios).
            #endregion


            #region problem 5
            //Robot robot = new Robot();

            //// normal method
            //robot.Walk();

            ////  explicit version
            //IWalkable walkableRobot = robot;
            //walkableRobot.Walk();

            // How does explicit interface implementation help in resolving naming conflicts?
            // Explicit interface implementation allows a class to implement interface members separately from its own public methods.
            #endregion

            #region problem 6
            //Account acc = new Account();

            //acc.AccountId = 101;
            //acc.AccountHolder = "Mahmoud";
            //acc.Balance = 5000;

            //acc.Display();


            //acc.Balance = -1000;  

            //acc.Display();

            // Question: What is the key difference between encapsulation in structs and classes?
            // The key difference is that classes are reference types while structs are value types. Although encapsulation works similarly in both (using private fields and public properties), structs are copied by value, creating independent instances, while classes are copied by reference, sharing the same underlying data.
            #endregion

            #region problem 7
            //ILogger logger2 = new DefaultLogger();
            //logger2.Log("Using default implementation");

            // How do default interface implementations affect backward compatibility in C#?
            // Default interface implementations allow developers to add new methods to an interface without breaking existing implementations.
            #endregion


            #region problem 8


            //Book book = new Book();
            //Book book2 = new Book("ahmed");
            //Book book3 = new Book("ahmed", "jooo");

            //book.Display();

            //book2.Display();

            //book3.Display();

            //How does constructor overloading improve class usability?

            // Constructor overloading improves class usability by providing multiple ways to initialize an object
            #endregion


            ///////////////     part02 in out file word and this code the part02     ////////////////////////


            #region Create a Shape Series
            //Console.WriteLine("Square Series:");
            //PrintTenShapes(new SquareSeries());

            //Console.WriteLine("\nCircle Series:");
            //PrintTenShapes(new CircleSeries());
            #endregion

            #region  Implement Sorting for Shapes 

            //     Shape2[] shape2 =
            //{
            //     new Shape2("Square", 16),
            //     new Shape2("Circle", 28.27),
            //     new Shape2("Rectangle", 20),
            //     new Shape2("Square", 9),
            //     new Shape2("Circle", 50.24)
            // };

            //     
            //     Array.Sort(shape2);

            //     Console.WriteLine("Shapes sorted by Area (Ascending):\n");

            //     foreach (var shape in shape2)
            //     {
            //         Console.WriteLine(shape);
            //     }
            #endregion

            #region Extend the Shape Hierarchy 

            //GeometricShape triangle = new Triangle(10, 5);
            //GeometricShape rectangle = new Rectangle2(8, 4);

            //Console.WriteLine("Triangle:");
            //triangle.Display();

            //Console.WriteLine("Rectangle:");
            //rectangle.Display();
            #endregion

            #region Implement Your Own Sorting 
            int[] shapeAreas = { 50, 20, 35, 10, 70, 5 };

            Console.WriteLine("Before Sorting:");
            PrintArray(shapeAreas);

            SelectionSort(shapeAreas);

            Console.WriteLine("\nAfter Sorting:");
            PrintArray(shapeAreas);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
            #endregion
    }

 }

