using System;
using System.Collections.Immutable;
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

            List<Product> ProductList = new List<Product>()
            {
                  new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                        UnitPrice = 6.0000M, UnitsInStock = 24 },
                    
            };
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

            #region Conversion (Imeediate)
            //List<Product> Productst = ProductList.Where(p => p.ProductID == 1).ToList();
            //var outOfStockList = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //var outOfStockArray = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //var dictionary = ProductList.Where(P => P.UnitsInStock == 0)
            //                            .ToDictionary(P => P.ProductID);
            //var dictionaryWithComparer = ProductList.Where(P => P.UnitsInStock == 0)
            //                                        .ToDictionary(P => P.ProductID,
            //new CustomEqualityComparer());


            //var dictionary02 = ProductList.Where(P => P.UnitsInStock == 0)
            //                              .ToDictionary(P => P.ProductID, P => P.ProductName);
            //var sortedCollection = ProductList.Where(p => p.ProductID == 1)
            //    .ToImmutableList();
            //sortedCollection.Add(new Product() { ProductName = "Beveragess" });
            //foreach (var product in sortedCollection)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Genertaion Csting
            //Call any of them by static method through IEnuemrable 
            // var result1 = Enumerable.Range(0, 100);
            #endregion

            #endregion

            #region Set Operators  Examples
            //var set1 = Enumerable.Range(0, 100);
            //var set2 = Enumerable.Range(0, 100);
            //var UnionSewithRemovingDuplicatet=set1.Union(set2);
            //var UnioonSetWithoutRemovingDuplicates = set1.Union(set2);
            //var IntersectionSet=set1.Intersect
            //    (set2);
            #endregion
            //I have to implemt IEQutable to compare based on state not refernce

            #region Union
            var Pset1 = new List<Product>()
            {
                 new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
                            UnitPrice = 18.00M, UnitsInStock = 100},
                    new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                    new Product{ ProductID =2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0M, UnitsInStock = 17 },

            };
            var Pset2 = new List<Product>()
            {
                  new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                      new Product{ ProductID = 1, ProductName = "Aniseed Syrup", Category = "Condiments",
                        UnitPrice = 10.0000M, UnitsInStock = 13 },

            };
            //var res = Pset1.Union(Pset2);


            //foreach (var product in res)
            //{
            //    Console.WriteLine(product);
            //}
            //same result insted of implemnt ProducComprer but must Imlment equal get hashcode
           // var res1 = Pset1.UnionBy(Pset2, p => p.ProductID);
            //incase category is class 
            //   var res2 = Pset1.UnionBy(Pset2, p => p.Category,new CtaegoryComparer();

            //Console.WriteLine("**************");
            //foreach (var product in res1)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Intersect     
            var Result = Pset1.Intersect(Pset2);


            //     Result = Pset1.Intersect(Pset2, new ProductEqualityComparer02());

            //    Result = Pset1.IntersectBy(Pset2.Select(P2 => P2.UnitsInStockS), p => p.UnitPrice);

            #endregion

            #region Disctint (filtertion Opertor)
            //Console.WriteLine("**************");
            //var res4 = Pset1.Distinct();
            //foreach (var product in res4)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine("**************");

            //var distinctById = Pset1.Distinct(new ProductEqualityComparer02());

            //foreach (var product in distinctById)
            //{
            //    Console.WriteLine(product);
            //}

            //incase category is sotheing that doesnt override ethashcode , equal
            //var dstctt = Pset1.DistinctBy(p=>p.Category, new ProductEqualityComparer02());
            #endregion


            #region Concat
            //merge withour removie dupliates

            #endregion


            #region Quanitifer operators return boolean
            //Console.WriteLine(ProductList.Any(p => p.UnitPrice > 20));{local, remote bec orm translated to  sql}
            //   ProductList.Exists(p=>p.UnitPrice>=200){local}
            //  Console.WriteLine(ProductList.All(p => p.UnitPrice > 20));
            //
            var product = new Product
            {
                ProductID = 2,
                ProductName = "Chang",
                Category = "Beverages",
                UnitPrice = 6.0000M,
                UnitsInStock = 17
            };

            #region Contain
            Console.WriteLine(ProductList.Contains(product));
            Console.WriteLine(ProductList.Contains(product, new ProductEqualityComparer02()));
            #endregion

            #endregion

            #region Transformation Operators (zip)
            List<string> Words = new List<string>() { "Ten", "Twenty", "Thirty", "Fourty" };

            long[] Numbers = { 10, 20, 30, 40, 50, 60, 70 };

            var res6= Numbers.Zip(Words);

            foreach (var item in res6)
                Console.WriteLine(item);
            var res7 = Numbers.Zip(Words, (Numbers, Words) => $"{Numbers}={Words}");

            foreach (var item in res7)
                Console.WriteLine(item);
            #endregion
        }
    }
}
