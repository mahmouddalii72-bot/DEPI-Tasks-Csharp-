using System;
using System.Collections.Generic;
using System.Linq;
using static Csharp.Day10.Employee;

namespace Csharp.Day10
{

    #region 1 to promlem 7
    public class Employee 
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }

        public class SortingAlgorithm<T>
        {
            public static void Sort(T[] array, Func<T, T, bool> compare)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compare(array[j], array[j + 1]))
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }


        public class SortingTwo1<T>
        {
            public static void Sort(T[] array, Func<T, T, bool> compare)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compare(array[j], array[j + 1]))
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }

        public class SortingTwo<T>
        {
            public static void Sort(T[] array, Func<T, T, bool> compare)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compare(array[j], array[j + 1]))
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }

public class SortingAlgorithm2<T> where T : ICloneable
    {
        public static void Sort(T[] array, Func<T, T, bool> compare)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (compare(array[j], array[j + 1]))
                    {
                        T temp = (T)array[j].Clone();   // Clone before swap
                        array[j] = (T)array[j + 1].Clone();
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

    }

    public class SortingAlgorithm<T>
    {

        public static void Sort(T[] array, Func<T, T, bool> compare)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (compare(array[j], array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }


        public static void Swap<U>(ref U a, ref U b)
        {
            U temp = a;
            a = b;
            b = temp;
        }

    }

    public class GenericUtils
    {
        public static T GetDefault<T>()
        {
            return default(T);
        }
    }


    public delegate int Operation(int x, int y);

    public class Calculator
    {
        public static int Execute(int a, int b, Operation operation)
        {
            return operation(a, b);
        }
    }

    public delegate R Transformer<T, R>(T input);


    public class ListConverter
    {
        public static List<R> Transform<T, R>(List<T> source, Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();

            foreach (var item in source)
            {
                result.Add(transformer(item));
            }

            return result;
        }
    }
    #endregion




    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //Employee[] employees =
            //{
            //    new Employee { Name = "Ali", Salary = 8000 },
            //    new Employee { Name = "Sara", Salary = 5000 },
            //    new Employee { Name = "Omar", Salary = 10000 }
            //};

            //SortingAlgorithm<Employee>.Sort(employees,
            //    (e1, e2) => e1.Salary > e2.Salary);

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //Question:
            //         What are the benefits of using a generic sorting algorithm over a non - generic one ?
            // solve ==> Generic sorting algorithm أكثر أمانًا، أسرع، وقابل لإعادة الاستخدام مقارنة بالـ non-generic implementation.

            #endregion

            #region problem 2
            //int[] numbers = { 3, 9, 1, 5, 7 };

            //SortingAlgorithm<int>.Sort(numbers, (x, y) => x < y);

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            // How do lambda expressions improve the readability and flexibility of sorting methods?
            // solve ==> Lambda expressions make sorting methods more readable by reducing boilerplate code and allowing inline comparison logic.
            #endregion

            #region problem 3
            //string[] words = { "Ahmed", "Ali", "Mohamed", "Omar" };

            //SortingAlgorithm<string>.Sort(words,
            //    (s1, s2) => s1.Length > s2.Length);

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            // A dynamic comparer function is important because it makes the sorting method more flexible, reusable, and maintainable by allowing different comparison rules without changing the sorting algorithm itself.
            #endregion

            #region problem 4
            ///// ...............
            #endregion

            #region problem 5
            //            Employee[] employees =
            //{
            //    new Employee { Name = "Ali", Salary = 8000 },
            //    new Employee { Name = "Mohamed", Salary = 12000 },
            //    new Employee { Name = "Sara", Salary = 9000 }
            //};

            //            Func<Employee, Employee, bool> compareByNameLength =
            //                (e1, e2) => e1.Name.Length > e2.Name.Length;

            //            SortingTwo<Employee>.Sort(employees, compareByNameLength);

            //            foreach (var emp in employees)
            //            {
            //                Console.WriteLine(emp);
            //            }


            // qoustion solve ===> Using built-in delegates like Func<T, T, TResult> simplifies generic programming by reducing boilerplate code, improving readability, and increasing flexibility when passing custom logic to methods.
            #endregion

            #region problem 6
            //int[] numbers = { 7, 2, 9, 1, 5 };

            //SortingTwo<int>.Sort(numbers,
            //    delegate (int x, int y)
            //    {
            //        return x > y;   // Ascending
            //    });

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            //int[] numbers = { 7, 2, 9, 1, 5 };

            //SortingTwo<int>.Sort(numbers,
            //    (x, y) => x > y);

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            // solve ==> Lambda expressions improve readability by providing a shorter and cleaner syntax compared to anonymous functions.

            #endregion


            #region problem 7
            //int[] numbers = { 3, 7, 1, 9 };

            //Console.WriteLine("Before Swap: " + string.Join(", ", numbers));

            //SortingAlgorithm<int>.Swap(ref numbers[0], ref numbers[2]);


            //Console.WriteLine("After Swap: " + string.Join(", ", numbers));

            // solve == > Generic methods like Swap<T> make utility functions reusable, type-safe, and maintainable, allowing the same logic to work for any data type without rewriting code.
            #endregion


            #region problem 8 
            //            Employee[] employees =
            //{
            //    new Employee { Name = "Ali", Salary = 8000 },
            //    new Employee { Name = "Omar", Salary = 8000 },
            //    new Employee { Name = "Sara", Salary = 9000 },
            //    new Employee { Name = "Mohamed", Salary = 8000 }
            //};

            //            // Custom comparison: Salary ascending, then Name ascending
            //            Func<Employee, Employee, bool> multiCriteriaCompare = (e1, e2) =>
            //            {
            //                if (e1.Salary == e2.Salary)
            //                {
            //                    return string.Compare(e1.Name, e2.Name) > 0;
            //                }
            //                return e1.Salary > e2.Salary;
            //            };

            //            SortingTwo1<Employee>.Sort(employees, multiCriteriaCompare);

            //            foreach (var emp in employees)
            //            {
            //                Console.WriteLine(emp);
            //            }

            // solve == > Implementing multi-criteria sorting in generic methods allows flexible and reusable sorting logic for complex objects, but it can increase the complexity and reduce readability. Properly designed comparers maintain consistent and predictable ordering.
            #endregion

            #region problem 9
            //int defaultInt = GenericUtils.GetDefault<int>();
            //Console.WriteLine($"Default int: {defaultInt}"); // 0

            //bool defaultBool = GenericUtils.GetDefault<bool>();
            //Console.WriteLine($"Default bool: {defaultBool}"); // False

            //string defaultString = GenericUtils.GetDefault<string>();
            //Console.WriteLine($"Default string: {defaultString ?? "null"}"); // null

            //Employee defaultEmployee = GenericUtils.GetDefault<Employee>();
            //Console.WriteLine($"Default Employee: {defaultEmployee ?? "null"}"); // null
            #endregion

            #region problem 10
            //            Employee[] employees =
            //{
            //    new Employee { Name = "Ali", Salary = 8000 },
            //    new Employee { Name = "Sara", Salary = 12000 },
            //    new Employee { Name = "Omar", Salary = 5000 }
            //};

            //            // Clone the array
            //            Employee[] clonedEmployees = employees.Select(e => (Employee)e.Clone()).ToArray();

            //            Console.WriteLine("Before Sort:");
            //            foreach (var e in clonedEmployees)
            //                Console.WriteLine(e);

            //            // Sort cloned array by Salary ascending
            //            SortingAlgorithm<Employee>.Sort(clonedEmployees, (e1, e2) => e1.Salary > e2.Salary);

            //            Console.WriteLine("\nAfter Sort:");
            //            foreach (var e in clonedEmployees)
            //                Console.WriteLine(e);
            #endregion


            #region  problem 11
            //Operation add = (x, y) => x + y;
            //Operation subtract = (x, y) => x - y;
            //Operation multiply = (x, y) => x * y;
            //Operation divide = (x, y) => x / y;

            //Console.WriteLine("Addition: " + Calculator.Execute(10, 5, add));
            //Console.WriteLine("Subtraction: " + Calculator.Execute(10, 5, subtract));
            //Console.WriteLine("Multiplication: " + Calculator.Execute(10, 5, multiply));
            //Console.WriteLine("Division: " + Calculator.Execute(10, 5, divide));
            #endregion

            #region problem 12
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Transformer<int, string> intToString = x => x.ToString();

            List<string> stringNumbers = ListConverter.Transform(numbers, intToString);

            foreach (var s in stringNumbers)
            {
                Console.WriteLine(s);
            }
            #endregion
        }
    }
}
