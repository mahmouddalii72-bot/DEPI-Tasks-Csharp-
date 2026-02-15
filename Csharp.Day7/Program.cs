using System;

namespace Csharp.Day7
{
    internal class Program
    {
        static void Main()
        {
            #region problem 1
            //Car c1 = new Car();
            //Car c2 = new Car(1);
            //Car c3 = new Car(2, "BMW");
            //Car c4 = new Car(3, "Mercedes", 500000);

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            // question ==>  bacouse the compiler make a  Default Constructor if not make a constructor .
            #endregion

            #region problem 2
            //Calculator calc = new Calculator();

            //int result1 = calc.Sum(5, 3);          // 8
            //int result2 = calc.Sum(2, 4, 6);        // 12
            //double result3 = calc.Sum(2.5, 3.7);    // 6.2

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);

            // Question: How does method overloading improve code readability and reusability?  

            // solve ==> improves reusability by preventing duplication of method names and organizing related functionality under a single method concept.
            #endregion

            #region problem 3
            //Child obj = new Child(1, 2, 3);
            //Console.WriteLine(obj);

            // What is the purpose of constructor chaining in inheritance ?

            // solve ==> Constructor chaining ensures that the base class is properly initialized before the derived class. It promotes code reuse, maintains object consistency, and enforces proper initialization of inherited members.
            #endregion

            #region prolem 4
            // by new 

            //parent p1 = new Child(2, 3, 4);
            //Console.WriteLine(p1.Product());  ///   6

            //// by override

            //parent p2 = new Child(2, 3, 4);
            //Console.WriteLine(p1.Product()); // 24

            //  q ==> The new keyword performs method hiding and resolves the method call at compile time based on the reference type, while override enables runtime polymorphism by resolving the method call at runtime based on the actual object type.
            #endregion


            #region problem 5
            //parent p1 = new parent(2, 3);
            //parent p2 = new Child(4, 5, 6);

            //Console.WriteLine(p1); // (2, 3)
            //Console.WriteLine(p2); // (4, 5, 6)

            // q ==> solve ==>ToString() is overridden to provide a meaningful string representation of an object. By default, it returns the class name, but overriding it improves debugging, logging, readability, and overall usability of the class.
            #endregion

            #region problem 6
            //IShape shape = new Rectangle(5, 4);

            //Console.WriteLine("Area: " + shape.Area); // 20
            //shape.Draw();

            #endregion

            #region problem 7
            //IShape shape = new Circle(3);

            //shape.Draw();
            //shape.PrintDetails();

            // q and solve ==> Default implementations allow adding new methods to interfaces without breaking existing implementations. They improve backward compatibility, enable code reuse, and support more flexible API evolution.
            #endregion

            #region problem 8
            //IMovable vehicle = new Car2("BMW");

            //vehicle.Move();
            #endregion

            #region problem 9
            File myFile = new File("data.txt");

            // Accessing methods via concrete class
            myFile.Read();
            myFile.Write();

            // Accessing via interface reference
            IReadable reader = myFile;
            reader.Read();

            IWritable writer = myFile;
            writer.Write();
            #endregion
        }
    }
}
