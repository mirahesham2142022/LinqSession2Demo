using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using static LinqDemo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Last (firstor last default) pt1 7&& pt2 
        
            List< Product>ProductList = new List<Product>();
            //var result = ProductList.First();
            //var result = ProductList.Last();
            // [First(Func), Last(Func)]
            // return First Or Last if exists otherwise throw exception
            // [FirstOrDefault, LastOrDefault]

            // return First Or Last   if exists otherwise return Null (defaultvalue)

            //var result = ProductList.FirstOrDefault();
            //var result=ProductList.LastOrDefault(new Product{ProductName="Mira"}


            // [FirstOrDefault(Func), LastOrDefault(Func)] //byakhdo predict func of 1 aparatmeter

            // var result = ProductList.LastOrDefault( product => product.UnitsInStock == -1);
            //4th overload 
            //   result=ProductList.LastOrDefault( product => product.UnitsInStock == -1,new Product( UnitsInStock=100));
            //Console.WriteLine(result?.ProductName ?? "NA");
            #endregion


            #region Elements / elemntordetault

            // result = ProductList.ElementAtOrDefault(100) ;
            //akhr index bybd2 from 1
            // var res = ProductList.ElementAt(10);
            //Console.WriteLine(res);
            //incase no elent in this will return null
            //  var res = ProductList.ElementAtOrDefault(10);
            #endregion

            #region Single , SingleOrDefault
            //var result = ProductList.Single();
            //  var discoountedroducts = new List<Product>();

            //single
            // if Sequance Have only element it will return that element
            //else Has more than or conain nothing  one element or has no elements throw exception 
            //singleOrDefault
            // if Sequance Have only element it will return that element
            //else if Has more than  one element will throw Exception
            //sequence has no elements return null(default value or product)

            //default
            //  var result = ProductList.SingleOrDefault(new Product(){ UnitsInStock=1000});
            // [Single(Func) , SingleOrDefault(Func)]
            // result = ProductList.SingleOrDefault( p => p.ProductID == 1);
            //first or default top1 
            //single ordefault top2
            //Hyper syntax
            //var res = (from e in ProductList
            //           where e.ProductID == 1
            //           select e).FirstOrDefault();
            #endregion


            #region Aggregate Operators => Immediate Execution

            //Count
            // var res = ProductList.Count;(proerty)
            //var result = ProductList.Count(); (Ienumerations)
            //count(predicte,Condition);


            /// var Count = ProductList.Count();
            //Count = ProductList.Count;
            ///// ProductList.TryGetNonEnumeratedCount(out Count);

            //var Numbers = Enumerable.Range(1, 100); // 1...100
            ///// var Count = Numbers.Count();
            //Numbers.TryGetNonEnumeratedCount(out var Count);

            ///// Count = ProductList.Where(P => P.UnitsInStock == 0).Count();
            ///// Count = ProductList.Count(P => P.UnitsInStock == 0);
            ///// ProductList.Where(P => P.UnitsInStock == 0).TryGetNonEnumeratedCount(out Count);

            //Console.WriteLine(Count);
            #region Sum/average
            //sum(selectore)

            //var result = ProductList.Sum(p => p.UnitPrice);

            //var result = ProductList.Average(p => p.UnitPrice);
            #endregion

            #region Max/Min
            //Awl pverload(implment I comparble)
            //var result = ProductList.Max(new ProductCompraer());
            //var result = ProductList.Max());
            //var result = ProductList.Min(new ProductCompraer());
            //var MaxProduct = ProductList.Max();
            //MaxProduct = ProductList.Max(new ProductCompraer());

            //MaxProduct = ProductList.MaxBy(P => P.UnitPrice);
            //MaxProduct = ProductList.MaxBy(P => P.UnitsInStock);
            //MaxProduct = ProductList.MaxBy(P => P.UnitsInStock, );

            //var MinProduct = ProductList.Min();
            //MinProduct = ProductList.Min(new ProductCompraer());

            //MinProduct = ProductList.MinBy(P => P.UnitPrice);
            //MinProduct = ProductList.MinBy(P => P.UnitsInStock);

            //10 overloads  (int nullbale etc)
            //compare according to The implemntion in how each data type Acording to I compareble
            //var MaxPrice = ProductList.Max(P => P.UnitPrice);
            //var Result = ProductList.Max(P => P.ProductName);
            //var MinPrice = ProductList.Min(P => P.UnitPrice);
            //Result = ProductList.Min(P => P.ProductName);

            //  Console.WriteLine(Result);
            #endregion
            #region Aggregate 
            string[] Names = { "Mira", "Dina", "hesham" };

            // Using Aggregate to concatenate all names with a space in between
            string FullName = Names.Aggregate((str01, str02) => $"{str01} {str02}");

            FullName = Names.Aggregate("Hello", (str01, str02) => $"{str01} {str02}");



            #endregion



            #region Orderby CountBy .net 9
            //var orders = new List<Order>;
            //var res = orders.OrderBy(o => o.CustomerId).ToList()
            //         .countBy(Order => Order.CutsomerId);
            #endregion




            #endregion



        }
    }
}
