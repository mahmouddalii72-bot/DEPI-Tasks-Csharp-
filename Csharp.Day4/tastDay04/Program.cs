using System;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml.Linq;

namespace tastDay04
{
    internal class Program
    {
        public static object endregion { get; private set; }

        static void Main()
        {
            #region problem 1
            //    // 1- fist 
            //    int[] arr1 = new int[3];
            //    arr1[0] = 10;
            //    arr1[1] = 20;
            //    arr1[2] = 30;

            //    Console.WriteLine("Array 1:");
            //    for (int i = 0; i < arr1.Length; i++)
            //        Console.WriteLine(arr1[i]);

            //    // 2- 
            //    int[] arr2 = { 1, 2, 3 };

            //    Console.WriteLine("Array 2:");
            //    foreach (int item in arr2)
            //        Console.WriteLine(item);

            //    // 3-  syntax sugar
            //    int[] arr3 = new int[] { 100, 200, 300 };

            //    Console.WriteLine("Array 3:");
            //    for (int i = 0; i < arr3.Length; i++)
            //        Console.WriteLine(arr3[i]);

            //    // 4- Demonstrate IndexOutOfRangeException
            //    Console.WriteLine("IndexOutOfRangeException Example:");
            //    //Console.WriteLine(arr1[5]); // error

            ////Question: What is the default value assigned to array elements in c#
            ////  solve ==> default=0   , and ret = null
            #endregion

            #region problem 2
            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = { 5, 6, 7, 8 };
            ////arr1 = arr2;
            ////Console.WriteLine(arr1[1]);  //6
            ////Console.WriteLine(arr2[1]);  //6
            //arr1 = (int[])arr2.Clone();
            ////Console.WriteLine(arr1.GetHashCode()); 58225482
            ////Console.WriteLine(arr2.GetHashCode()); 54267293
            ////Console.WriteLine(arr1[1]);  //6
            ////Console.WriteLine(arr2[1]);  //6

            ////  Question: What is the difference between Array.Clone() and Array.Copy()? 
            ////   solve  Array.Clone() ==> creates and returns a new array copy (as object) and copies the whole array.
            ////          Array.Copy()  ==> copies elements into an existing array, returns void, and allows partial copying.

            #endregion

            #region problem 3

            //int[,] grades = new int[3, 3]; // 3 students, 3 subjects

            //// Take input
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            // Print grades
            //Console.WriteLine("Students Grades:");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();



            #endregion

            #region problem 4

            //int[] arr01 = { 7, 9, 3, 4, 10, 6, 1, 8, 2, 5 };
            //int[] arr02 = { 20, 21,22 };
            ////Console.WriteLine(arr01);
            //Array.Sort(arr01);
            //Console.WriteLine(string.Join(",",arr01));
            //Array.Reverse(arr01);
            //Console.WriteLine(string.Join(",", arr01));
            //int Indexof2 = Array.IndexOf(arr01, 2);
            //Console.WriteLine(Indexof2);
            //Array.Copy(arr01,arr02,3);
            //Console.WriteLine(string.Join(",", arr02));
            //Array.Clear(arr01,2,4);
            //Console.WriteLine(string.Join(",", arr01));


            //  What is the difference between
            //  Array.Copy() === Faster, but may partially copy data if an error occurs.
            //  Array.ConstrainedCopy() === Safer, either copies all elements or copies nothing. ?

            #endregion

            #region problem 5
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //// Using for loop
            //Console.WriteLine("For loop:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //// Using foreach loop
            //Console.WriteLine("\nForeach loop:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //// Using while loop to print in reverse
            //Console.WriteLine("\nWhile loop (reverse):");
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;
            //}


            //Question: Why is foreach preferred for read-only operations on arrays? 
            // foreach is preferred for read-only operations because it automatically iterates
            // through the array and prevents accidental modification of elements.

            #endregion

            #region problem 1
            //int result;
            //do
            //{
            //    Console.WriteLine("enter your number");
            //    bool flag = int.TryParse(Console.ReadLine(), out result);
            //    if (!flag || result <= 0 || result % 2 == 0)
            //    {
            //        Console.WriteLine("the number is fals");
            //    }
            //}
            //while (true);
            //Console.WriteLine($"the true nuber is : {result}");


            //QUESTION
            // =====>> to prevent the crash prevention

            #endregion

            #region problem 2
            //int[,] arr = { { 5, 6, 7 },{ 1,2,3},{ 8,9,6} };

            //for (int i = 0;i<arr.GetLength(0);i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }

            //    Console.WriteLine();

            //}

            //question: ===> like up look
            #endregion

            #region problem 3 if & switch


            //Console.WriteLine("enter the mounth number");
            //int res = int.Parse(Console.ReadLine());
            //if (res == 1)
            //{
            //    Console.WriteLine("the month name is :: {april}");
            //}
            //else if (res == 2)
            //{
            //    Console.WriteLine("the month name is :: {march}");
            //}
            //else if (res == 3)
            //{
            //    Console.WriteLine("the month name is :: {jul}");
            //}
            //else
            //    Console.WriteLine(" not vilad number");

            //switch (res)
            //{
            //    case 1: 
            //        Console.WriteLine("the month name is :: {april}");
            //        break;

            //    case 2:
            //        Console.WriteLine("the month name is :: {march}");
            //        break;

            //    case 3:
            //        Console.WriteLine("the month name is :: {jul}");
            //        break;
            //    default:
            //        Console.WriteLine("not vild number");
            //        break;
            //}

            //answer  ====> on the number of cases in generl the switch better

            #endregion

            #region problem 4
            //int[] arr = { 4, 3, 2, 1, 0,4,7,9,4,7 };
            //Array.Sort(arr);
            //int firstindex =Array.IndexOf(arr, 7);
            //int lastindex =Array.LastIndexOf(arr,7);
            //Console.WriteLine("the sorted array is :" + String.Join(" ," , arr ));
            //Console.WriteLine($" the first :{firstindex}, last :{lastindex}");

            //question  ==>> O(n log n) time
            #endregion

            #region problem 5
            //int[] numbers = { 1, 2, 3, 4, 5 };


            //// Calculate sum using for loop
            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++) { 
            //    sumFor += numbers[i]; 
            //} Console.WriteLine("Sum using for loop: " + sumFor); 


            //// Calculate sum using foreach loop
            //int sumForeach = 0;
            //foreach (int num in numbers) {
            //    sumForeach += num; 
            //} Console.WriteLine("Sum using foreach loop: " + sumForeach);


            //eq solv  ====>  The for loop is slightly more efficient because it directly indexes into the array without creating an enumerator.
            //because   1-    Use for loop if you care about raw performance or need index control
            //          2-    Use foreach loop if you care more about readability and simplicity.
            #endregion

        }
    }
}
