using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection;
using static LinqDemo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LinqDemo.ListGenerator;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Runtime.InteropServices;
namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock
           var res  = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
          Console.WriteLine(res);
            #endregion
            #region   2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //res = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(res);
            //Console.WriteLine(res?.ProductName??"NA");

            #endregion
            #region    3.Retrieve the second number greater than 5
              List<int> numbers = new List<int>()
              {
                    1,2, 3, 4,5,6,7,9,45
              };
            var res1 = numbers.Where(n => n > 5).ElementAt(1);
            Console.WriteLine(res1);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var rse2 = Arr.Where(a => a % 2 == 1).Count();
            Console.WriteLine(rse2);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            var Orders = new List<Order>()
            {
                new Order(1,new DateTime(1/12024),5000,1),
                new Order(2,new DateTime(1/12024),5000,4),
                new Order(3,new DateTime(1/12024),5000,3),
                new Order(4,new DateTime(1/12024),5000,2),


            };
            //var CountOfCustomersOrders = Orders.OrderBy(o => o.customerId)
            //                            .ToList().Count(o => o.customerId);
            //foreach(var Res in CountOfCustomersOrders)
            //{
            //    Console.WriteLine(Res);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            var ress = ProductList.OrderBy(p=>p.Category)
                          .Count();
            Console.WriteLine(ress);
            #endregion

            #region 4. Get the total of the numbers in an array.
            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var sum1 = Arr1.Sum();
            Console.WriteLine(sum1);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).



            #endregion
            #region 9. Get the total units in stock for each product category.
            var res6 = ProductList .GroupBy(p => p.Category)
               .Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.UnitsInStock) });

            foreach (var o in res6)
            {
                Console.WriteLine($"Category{o.Category}, Total Units{o.TotalStock}");
            }
            #endregion
            #region             10.Get the cheapest price among each category's products

            //var res7 = ProductList.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key ,Minimum=g.Min(p=>p.UnitPrice)});
            //foreach(var min in res7)
            //{
            //    Console.WriteLine( $"{min.Category},{min.Minimum}");
            //}
            #endregion
            Console.WriteLine("******************");
            #region   11.Get the products with the cheapest price in each category(Use Let)

            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var ExpenisveProduct = ProductList.GroupBy(p => p.Category)
            //         .Select(g => new { category = g.Key, Max = g.Max(g => g.UnitPrice) });
            //foreach (var max in ExpenisveProduct)
            //{
            //    Console.WriteLine($"{max.category},{max.Max}");
            //}
            #endregion
            #endregion
        }
    }
}
