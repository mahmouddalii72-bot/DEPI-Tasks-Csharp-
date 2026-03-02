using LINQ.Day02;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading;
using static LINQ.Day02.ListGenerators;
using static System.Net.WebRequestMethods;

namespace LINQ.Day02
{
    class Program
    {
        static void Main()
        {
            #region Restriction Operators 

            ///  1
            //var Res = ProductList.Where((P) => P.UnitsInStock==0).Select((P) => P.ProductName);

            // 2
            //var Res = ProductList
            //.Where(p => p.UnitsInStock > 0
            //         && p.UnitPrice > 3.00m);

            // 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };

            //        var Res = Arr
            //.Select((p, i) => new { p, i })
            //.Where(x => x.p.Length < x.i)
            //.Select(x => x.p);


            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Element Operators 
            //var res=   ProductList.First((p)=>p.UnitsInStock==0);
            //var res=   ProductList.FirstOrDefault((p)=>p.UnitPrice>100);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(p => p > 5).Skip(1).First();
            //Console.WriteLine(res);
            #endregion


            #region  Aggregate Operators 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Count((p )=> p % 2 != 0);

            //var res = CustomerList.SelectMany((C) => C.Orders);
            //var res = ProductList.SelectMany((p) => p.Category).Count();

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum();

            //Console.WriteLine(res);

            ///////////////////////////////// bouns in anther page  /////////////////////////////////////////////////

            #endregion



            #region Ordering Operators
            //var res = ProductList.OrderBy((p) => p.ProductName);


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in )
            //{
            //    Console.WriteLine(item);
            //}

            //var res = ProductList.OrderByDescending((p) => p.UnitsInStock);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };

            //var res = Arr.OrderBy(p => p.Length).ThenBy((p)=>p);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}



            //string[] words = {"aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var sorted = words
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //var res = ProductList.OrderByDescending((p) => p.Category).ThenBy((p) => p.UnitPrice);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}



            //            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //"nine" };

            //            var result = Arr.Where(w => w.Length > 1 && w[1] == 'i').Reverse();

            //            foreach (var item in result)
            //            {
            //                Console.WriteLine(item);
            //            }

            #endregion



            #region Transformation Operators 

            //var  res = ProductList.Select((p) => p.ProductName);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" }; 

            //        var res =words.Select(w => new {
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //        var res = ProductList
            //.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,       
            //    p.UnitsInStock,
            //    p.Category
            //});

            //        foreach (var item in res)
            //        {
            //            Console.WriteLine(item);
            //        }



            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = from val in Arr.Select((value, index) => new { value, index })
            //             select new
            //             {
            //                 val.index,
            //                 val.value,
            //                 MatchesPosition = val.value == val.index
            //             };


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}


            #endregion


            #region   Aggregate Operators 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Count((p) => p != 0);

            //Console.WriteLine(res);


            //var res = CustomerList.SelectMany(p => p.Orders);


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum (x=>x);
            // Console.WriteLine(res);



            //string[] words = File.ReadAllLines("dictionary_english.txt");


            //int totalCharacters = words.Sum(w => w.Length);

            //Console.WriteLine($"Total Characters = {totalCharacters}");



            //string[] words = File.ReadAllLines("dictionary_english.txt");


            //int shortestLength = words.Min(w => w.Length);

            //Console.WriteLine($"Shortest Word Length = {shortestLength}");



            //var cheapPrice = ProductList.Min((p) => p.UnitPrice);
            //Console.WriteLine(cheapPrice.ToString());



            //        var cheapestInCategory = ProductList
            //.GroupBy(p => p.Category)              // نجمع حسب الكاتيجوري
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g.OrderBy(p => p.UnitPrice)   // نرتب المنتجات داخل الكاتيجوري حسب السعر
            //                .Take(1)                     // ناخد الأرخص بس
            //});

            //        Console.WriteLine(cheapestInCategory);

            //        foreach (var cat in cheapestInCategory) { Console.WriteLine(cat.Category); }



            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Max((p) => p.Length);
            //Console.WriteLine(res);


            //var res = ProductList.GroupBy(p => p.Category).Select((p) => new {cat = p.Key, max = p.Max(p => p.UnitPrice)   });
            //Console.WriteLine(res);

            //foreach (var item in res) {Console.WriteLine(item);}





            //var res = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    exp = p.Max(k=>k.UnitPrice)
            //});

            //foreach (var item in res) { Console.WriteLine(item); }




            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res2 = words.Average(x => x.Length);
            //Console.WriteLine(res2);


            //var res = ProductList.GroupBy(p => p.Category).Select(p => new { cat = p.Key, ave = p.Average(k => k.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion



            #region  Ordering Operators 

            //var res = ProductList.OrderBy(p => p.ProductName);

            //foreach(var item in res)
            //{
            //    Console.WriteLine(item.ProductName);
            //}




            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr.OrderBy(x => x);

            //foreach (var x in sorted)
            //{
            //    Console.WriteLine(x);
            //}



            //var res = ProductList.OrderBy(p => p.UnitsInStock);

            //    foreach (var x in res)
            //{
            //    Console.WriteLine(x);
            //}


            //String[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}; 

            //var word = Arr.OrderBy(p=>p.Length).ThenBy(p=>p);


            //foreach (var x in word)
            //{
            //    Console.WriteLine(x);
            //}


            //        String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //        var sorted = Arr
            //.OrderBy(w => w.Length)                                  
            //.ThenBy(w => w);       

            //        foreach (var word in sorted)
            //        {
            //            Console.WriteLine(word);
            //        }



            //var res = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //Console.WriteLine(res);

            //foreach (var word in res)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region - Partitioning Operators 


            //var res  = CustomerList
            // .Where(c => c.City == "Washington")    
            // .SelectMany(c => c.Orders)            
            // .Take(3);


            //var res = CustomerList
            // .Where(c => c.City == "Washington")
            // .SelectMany(c => c.Orders).
            // Skip(3);

            //foreach (var c in res)
            //{
            //    Console.WriteLine(c);
            //}




            //        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //        var result = numbers
            //.TakeWhile((value, index) => value >= index);

            //        foreach (var n in result)
            //        {
            //            Console.WriteLine(n);
            //        }



            //        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //        var result = numbers
            //.SkipWhile(n => n % 3 != 0);

            //        foreach (var num in result)
            //        {
            //            Console.WriteLine(num);
            //        }




            //        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //        var result = numbers
            //.SkipWhile((num, index) => num >= index);

            //        foreach (var num in result)
            //        {
            //            Console.WriteLine(num);
            //        }


            #endregion



            #region Quantifiers


            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(containsEi);



            var result = ProductList
         .GroupBy(p => p.Category)
         .Where(g => g.Any(p => p.UnitPrice > 1));

            foreach (var x in result)
            {
                Console.WriteLine($"Category: {x.Key}");
                foreach (var product in x)
                {
                    Console.WriteLine($"  {product.ProductName} - {product.UnitsInStock}");
                }
            }
            #endregion
        }
    }
}
