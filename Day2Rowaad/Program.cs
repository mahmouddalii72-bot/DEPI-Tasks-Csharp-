using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Day2Rowaad
{
    internal class Program
    {
        static void Main()
        {

            #region problem 1

          //this programe calculates the sum 

            /*
            this programe
            calculates the sum
            and print in console
            */
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine(sum);

            #endregion

            #region Question -the shortcut to comment and uncomment 

            //By ctrl +k

            #endregion

           

            #region problem 2 
            //errer in x take string not number 
            //And y not identfiy
            int x = "10";
            Console.WriteLine(x + y);

            #endregion

             #region Question - a runtime error and a logical error 
            // Runtime error ==== is found when the program run
            int x = 10;  
            int y = 0;
            Console.WriteLine(x / y); // erorr

           //logical error ====   is mean the program run and error in the result
           int x = 5; 
           int y = 5;
           Console.WriteLine(x - y); // erorr

            #endregion


            #region problem 3

            string fullName = "mahmoud Ali";
            int age = 22;
            double monthSalary = 6000;
            bool isStudent = true;

            #endregion


            #region question - Why is it important to follow naming conventions such as PascalCase in C#? 

            //Because this easy to every one use this code and understand what I mean like the last problem

            #endregion





            #region problem 4

            //thisthe reference type = 
            int x = 6;
            int y = x;

            #endregion

            #region problem 5
            //Create a program that calculates the following using variables x = 15 and y = 4: 

            int x2 = 15;
            int y2 = 4;

            //Sum
            Console.WriteLine(x2 + y2); 

            // Difference
            Console.WriteLine(x2 - y2);

            // Product
            Console.WriteLine(x2 * y2);

            // Division
            Console.WriteLine(x2 / y2);

            // Remainder
            Console.WriteLine(x2 % y2);

            #endregion

            #region Question - output of the following code?

            //output will be = 1  because % mean the Remainder from the divisions

            #endregion

            #region Problem 6 - Check number > 10 and even
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 10 && num % 2 == 0)
                Console.WriteLine("Number is greater than 10 and even");
            else
                Console.WriteLine(" not satisfied");
            #endregion


            #region Question  - && vs &
            /*
             && (Logical AND):
             - Works with boolean values
             - Uses short-circuit (stops if first condition is false)

             & (Bitwise AND):
             - Works with bits or booleans
             - Evaluates both conditions always
            */
            #endregion


            #region Problem 7 - Casting double to int
            Console.Write("Enter a double number: ");
            double d = double.Parse(Console.ReadLine());

            int explicitCast = (int)d;     // explicit casting
            double implicitCast = explicitCast; // implicit casting

            Console.WriteLine("Explicit cast: " + explicitCast);
            Console.WriteLine("Implicit cast: " + implicitCast);
            #endregion


            #region Question  - Why explicit casting?
            /*
             Explicit casting is required because:
             - double has decimal values
             - int cannot store decimals
             - data loss may occur
            */
            #endregion


            #region Problem 8 - Age as string (Parse)
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            try
            {
                int age = int.Parse(ageInput);

                if (age > 0)
                    Console.WriteLine("Valid age");
                else
                    Console.WriteLine("Invalid age");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }
            #endregion


            #region Question  - Possible Exception
            /*
             FormatException may occur
             Handling:
             - Use try-catch
             - Or int.TryParse()
            */
            #endregion


            #region Problem 8 - Prefix vs Postfix Increment
            int x = 5;

            int y = ++x + x++;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            #endregion


            #region Question  - Final value explanation
            /*
             ++x  -> x becomes 6, used as 6
             x++  -> used as 6, then becomes 7

             y = 6 + 6 = 12
             final x = 7
            */
            #endregion

           

        }
    }
}
