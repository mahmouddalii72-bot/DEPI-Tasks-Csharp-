using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp.Day3
{
    internal class Program
    {
        static void Main()
        {
            #region problem 1 deffrence between them deal with null
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //try
            //{
            //    // Using int.Parse
            //    int number1 = int.Parse(input);
            //    Console.WriteLine("int.Parse result: " + number1);

            //    // Using Convert.ToInt32
            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine("Convert.ToInt32 result: " + number2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: The input is not a valid number.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error: The number is too large or too small.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Unexpected error: " + ex.Message);
            //}

            //// Question: What is the difference between int.Parse and Convert.ToInt32 when
            ////  handling null inputs ?
            //// the difference that int.parse ====>return error 
            ////                     ToInt32 ====>return 0 

            #endregion

            #region problem 2

            //Console.Write("Enter a number: ");
            //string number = Console.ReadLine();

            //bool S = int.TryParse(number,out int X);
            //Console.WriteLine(S);
            //Console.WriteLine(number);

            //  Question: Why is TryParse recommended over Parse in user - facing applications ?
            //  becaue it easy and return true or false not exception
            #endregion

            #region problem 3

            //Object M = new Object();
            //Console.WriteLine(M.GetHashCode()); //  33476626
            //  Question: Explain the real purpose of the GetHashCode() method. 
            // to knowe the to object  address in memory 
            #endregion

            #region problem 4
            //Object M = new Object();
            //Object R = new Object();
            //Console.WriteLine(R.GetHashCode()); // 33476626
            //Console.WriteLine(M.GetHashCode()); // 32854180
            //R = M;
            //Console.WriteLine(R.GetHashCode()); // 32854180
            //Console.WriteLine(M.GetHashCode()); // 32854180

            //Q::  checks identity
            #endregion

            #region problem 5 
            //StringBuilder SB = new StringBuilder(" Hi ");
            //Console.WriteLine(SB);//Hi
            //Console.WriteLine(SB.GetHashCode()); //58225482
            //SB.Append("Willy");
            //Console.WriteLine(SB); // Hi Willy
            //Console.WriteLine(SB.GetHashCode()); //58225482 
            #endregion

            #region problem 6
            //QUESTION ::
            //can change old value
            //// Mutable 
            //// internally Linkedlist of chars
            #endregion

            #region pronlem 7 
            //Console.Write("Enter first number: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;

            //// 1. Concatenation
            //Console.WriteLine("Sum is " + sum);

            //// 2. Composite formatting
            //Console.WriteLine(string.Format("Sum is {0}", sum));

            //// 3. String interpolation
            ////Console.WriteLine($"Sum is {sum}");

            ////  Question: Which string formatting method is most used and why? the {3} the laste versio
            #endregion

            #region problem 8
            StringBuilder sb = new StringBuilder();

            // 1. Append text
            sb.Append("Hello World");
            Console.WriteLine("After Append: " + sb);

            // 2. Replace a substring
            sb.Replace("World", "C#");
            Console.WriteLine("After Replace: " + sb);

            // 3. Insert a string at a specific position
            sb.Insert(6, "Amazing ");
            Console.WriteLine("After Insert: " + sb);

            // 4. Remove a portion of text
            sb.Remove(6, 8); // removes "Amazing "
            Console.WriteLine("After Remove: " + sb);
            #endregion
        }
    }
}
