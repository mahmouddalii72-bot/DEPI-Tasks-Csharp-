using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace task.Day5
{
    internal class Program
    {
        static void Main()
        {
            #region problem 1



            //try
            //{
            //    // risky code


            //    Console.WriteLine($"enter x ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"enter y ");
            //    int y = int.Parse(Console.ReadLine());


            //    int z = x / y;
            //    Console.WriteLine($"the result :  {z}");
            //}

            //catch (DivideByZeroException Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //finally {
            //    Console.WriteLine("thw number not vilad");
            //}


            ///  Question: What is the purpose of the finally block? 
            // Solve:: The finally block is used to execute code that must run whether an exception occurs or not, mainly for cleaning up resources.





            #endregion

            #region problem 2

            //      int X, Y, Z;
            //      bool flag;
            //      do
            //      {
            // //         Console.WriteLine("Enter first Number : ");
            //      }
            //      while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            //      do
            //      {
            //          Console.WriteLine("Enter Second Number : ");
            //      }
            //      while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 0);

            //      Z = X / Y;

            //      Console.WriteLine($"the res : {Z}");

            //  Question: How does int.TryParse() improve program robustness compared to  int.Parse() ?

            //solve::because  int.TryParse() try to convert the input to int and return flase and prevent exeption



            #endregion

            #region problem 3
            //int? number = 12;
            //int result = number ?? 10;
            //Console.WriteLine("Result: " + result);

            //int? number = null;

            ////if (number.HasValue)
            //{
            //      Console.WriteLine(number.Value);
            //}
            //else
            //{
            //    Console.WriteLine("the number is null");
            //}

            // question : 
            // siolve : will return InvalidOperationException

            #endregion

            #region problem 4

            //try
            //{
            //    // risky code


            //    int[] arr = { 1, 2, 3, 4, 5 };




            //    Console.WriteLine($"the result :  {arr[30]}");
            //}

            //catch (IndexOutOfRangeException Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}

            //   Question: Why is it necessary to check array bounds before accessing elements ?
            // solve :::   to perenent stop the progrem and do exception 


            #endregion

            #region problem 5

            //// Declare a nullable integer
            //int[,] arr = new int[3, 3];

            //// Taking input from user
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Sum of each row
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        rowSum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum of row {i}: {rowSum}");
            //}

            //// Sum of each column
            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        colSum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum of column {j}: {colSum}");
            ////}

            #endregion

            #region problem 6

            // Create a jagged array with 3 rows of different sizes
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[4];

            //// Populate array with user input
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter values for row {i}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Print all values
            //Console.WriteLine("\nJagged Array values:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //  How does the memory allocation differ between jagged arrays and rectangular arrays?
            //  solve :
            //
            //  Jagged Arrays (int[][])

            // Each row is a separate array allocated independently in memory.

            //   Rows can have different lengths.

            //Memory is not contiguous for all elements.

            //Rectangular Arrays(int[,])

            //Stored as one single block of memory.

            //All rows have the same number of columns.

            //Memory is contiguous.


            #endregion

            #region problem 7
            // Nullable string


            //Console.Write("Enter your name: ");
            //string? name = Console.ReadLine();

            // Null-forgiveness operator
            //Console.WriteLine(name!);

            //  Purpose of nullable reference types ?
            // warning to avoid null ref exception 

            #endregion

            #region problem 8
            //    int sum, product;

            //    SumAndMultiply(3, 4, out sum, out product);

            //    Console.WriteLine("Sum = " + sum);
            //    Console.WriteLine("Product = " + product);
            //}

            //static void SumAndMultiply(int a, int b, out int sum, out int product)
            //{

            //    sum = a + b;
            //    product = a * b;
            #endregion

            #region problem  9
            //    // Using default value (optional parameter)
            //    PrintText("Hello");

            //    // Using named parameter
            //    PrintText(text: "Hi", times: 3);
            //}

            //static void PrintText(string text, int times = 5)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        Console.WriteLine(text);
            //    }


            //  Why must optional parameters always appear at the end of a method's parameter list?
            // solve ::: Because the compiler matches arguments to parameters in order, and placing optional parameters at the end prevents ambiguity about which values are being passed.
            #endregion

            #region problem  10
            //int[]? numbers = {9,9,7};


            //int? length = numbers?.Length;

            //Console.WriteLine("Array Length: " + length);

            ///  q ::
            ///  solve :: It checks for null before accessing a member and returns null instead of throwing an exception.

            #endregion

            #region problem 11
            //Console.Write("  enter number of the month here ==>  ");
            //int input = int.Parse(Console.ReadLine());

            //switch (input) {
            //    case 1: Console.WriteLine("sunday");

            //        break;
            //    case 2: Console.WriteLine("monday");
            //        break;
            //    case 3: Console.WriteLine("Tuesday"); 
            //        break;
            //    case 4: Console.WriteLine("wesday");
            //        break;

            //    default: Console.WriteLine("not a correct number !!");
            //        break;

            //}
            //;

            //  Question: When is a switch expression preferred over a traditional if statement? 
            //  slove : when we will check more then 3 case 

            #endregion

            #region problem 12 
            //    int result1 = SumArray(1, 2, 3, 4);
            //    Console.WriteLine("Sum = " + result1);


            //    int[] numbers = { 5, 10, 15 };
            //    int result2 = SumArray(numbers);
            //    Console.WriteLine("Sum = " + result2);
            //}

            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;

            //    foreach (int n in numbers)
            //    {
            //        sum += n;
            //    }

            //    return sum;

            // What are the limitations of the params keyword?
            // solve : Only one params parameter is allowed in a method, It must be the last parameter in the method signature, and single de array 
            #endregion


            ///////////////////////           part02             /////////////////////////////

            #region Program to Print Numbers in a Range

            //Console.Write("enter your number ==> ");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input ; i++) {
            //    Console.Write(i);
            //    Console.WriteLine();
            //}

            #endregion


            #region Program to Display Multiplication Table 

            //Console.Write("enter your number ==> ");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    Console.Write(i*input);
            //    Console.WriteLine();
            //}
            #endregion


            #region Program to List Even Numbers
            //Console.Write("enter your number ==> ");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= input; i=i+2)
            //{
            //    Console.Write(i);
            //    Console.WriteLine();
            //}

            #endregion

            #region Program to Compute Exponentiation 
            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the power: ");
            //int power = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine("Result = " + result);


            #endregion

            #region Program to Reverse a Text String 

            //string text = Console.ReadLine();

            //for(int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}


            #endregion


            #region Program to Reverse an Integer Value 
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (num != 0)
            //{
            //    int digit = num % 10;      // آخر رقم
            //    reversed = reversed * 10 + digit;
            //    num /= 10;                 // نشيل آخر رقم
            //}

            //Console.WriteLine("Reversed number = " + reversed);
            #endregion

            #region Program to Find Longest Distance Between Matching Elements 

            //int[] arr = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 37, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 37, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int maxDistance = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; 
            //            if (distance > maxDistance)
            //                maxDistance = distance;
            //        }
            //    }
            //}

            //Console.WriteLine("Longest distance = " + maxDistance);
            #endregion

            #region  Program to Reverse Words in a Sentence 
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();


            //string[] words = sentence.Split(' ');


            //Array.Reverse(words);


            //Console.WriteLine(string.Join(" ", words));
            #endregion

        }
    }

    }

