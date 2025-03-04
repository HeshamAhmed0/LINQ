using System.Collections;
using Session01.Data;

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Linq Syntax

            #region Fluent Syntex
            //List<int> list = new List<int>() { 1,2,3,4,5,6};
            //List<int> OddNums = list.Where(num => num%2==0).ToList();
            //foreach (int num in OddNums) { Console.WriteLine(num); }

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var OddNumber =Enumerable.Where(list,num => num % 2 == 0);
            //foreach (var num in OddNumber)
            //{
            //    Console.Write($"{num} ");
            //}

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var OddNumber = list.Where(num => num % 2 == 0);
            //foreach (int num in OddNumber)  {Console.WriteLine(num); }  
            #endregion

            #region Query Syntex
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7};
            //var OddNumbers = from L in list
            //                 where L % 2 == 0
            //                 select L;
            //foreach (var o in OddNumbers) { Console.Write($"{o} "); }
            #endregion
            #endregion

            #region Execution Ways
            #region Deferred Executio [Last Version Of Elements]
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var EvenNumbers = numbers.Where(num => num % 2 == 1);
            //numbers.AddRange(new int[] { 1, 101, 20, 401, 50 });
            //foreach (var Numbers in EvenNumbers) { Console.WriteLine($"{Numbers} "); }
            #endregion

            #region Immediate Execution
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var EvenNumbers = numbers.Where(num => num % 2 == 1).ToList();
            //numbers.AddRange(new int[] { 1, 101, 20, 401, 50 });
            //foreach (var Numbers in EvenNumbers) { Console.WriteLine($"{Numbers} "); }
            #endregion
            #endregion

            #region Apply For Class ListGenerator

            #region Test ListGenerator
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.customerList[0]); 
            #endregion

            #region Where
            // Fluent Syntax
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var Product in Result) 
            //{
            //    Console.WriteLine(Product);
            //}


            //Query Syntax  

            //Result = from P in ListGenerator.ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            // Fluent Syntax
            ////var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            //Query Syntax
            //var Result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #region Indexed Where

            //var Result = ListGenerator.ProductList.Where((S, L) => L < 10 && S.UnitsInStock > 0);

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //} 
            #endregion
            #endregion


            #region Select && Select Many 
            #region Select 
            //Fluent Syntax
            //var Result = ListGenerator.ProductList.Select(P => P.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax
            //var Result = from P in ListGenerator.ProductList
            //             select P.ProductName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            // Select From Customer 
            //var Result = ListGenerator.customerList.Select(P => P.CustomerName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //var Result =from P in ListGenerator.customerList
            //            select P.CustomerName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Fluent Syntax 
            //var Result = ListGenerator.customerList.SelectMany(P => P.Orders);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // Query Syntax 
            //var Result = from C in ListGenerator.customerList
            //             from O in C.Orders
            //             select O;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            // Fluent Syntax
            //var Result = ListGenerator.ProductList.Select(P => new {ProductName = P.ProductName , ProductId =P.ProductID});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            // Fluent Syntax 
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0)
            //                                     .Select(P=> new {
            //                                     ProductName =P.ProductName,
            //                                     productId =P.ProductID,
            //                                     OldSalary=P.UnitPrice,
            //                                     NewSalary=P.UnitPrice-P.UnitPrice * 0.1M,
            //                                     });


            //Query Syntax

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Order Operators

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.UnitPrice).ThenByDescending(P => P.ProductID);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Element Operator
            //var Result =ListGenerator.ProductList.First();
            // Result =ListGenerator.ProductList.Last();
            // Result =ListGenerator.ProductList.FirstOrDefault();
            // Result =ListGenerator.ProductList.LastOrDefault();
            // Result =ListGenerator.ProductList.ElementAt(0);
            // Result =ListGenerator.ProductList.ElementAtOrDefault(0);
            // Result =ListGenerator.ProductList.Single();
            // Result =ListGenerator.ProductList.SingleOrDefault();


            //Console.WriteLine(Result);
            #endregion

            #region Aggregate Operator

            #region Count
            //var Result = ListGenerator.ProductList.Count();//LINQ Operator
            //Result = ListGenerator.ProductList.Count();// List Operator
            #endregion

            #region Max ^^ Min
            //var Result = ListGenerator.ProductList.Max();
            //var Result = ListGenerator.ProductList.Min();
            //Console.WriteLine(Result);
            #endregion

            //string[] names = { "hesham", "ahmed", "hassan" };
            //var result= names.Aggregate((str01,str02)=> $"{str01} {str02}");
            //Console.WriteLine(result);
            #endregion



            #endregion

            #region Castin Operator 
            //List<Product> Product01=ListGenerator.ProductList.Where(P => P.UnitsInStock==0).ToList();   //  Cassting to List
            //Product[] Product01=ListGenerator.ProductList.Where(P => P.UnitsInStock==0).ToArray();       //  casting to array 

            //Dictionary<long, Product> DProduct = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);   // Casting To Dictionary  // First Overlad


            //Dictionary<long, string> DProduct = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID,P=>P.ProductName);   

            //HashSet<Product> HashSetProduct = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();   

            //ArrayList obj =new ArrayList()
            //{
            //    "Hesham",
            //    "Ahmed",
            //    1,
            //    2,
            //    3,
            //    5
            //};
            //var Result = obj.OfType<string>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generation Operator

            /* Range Operator */

            // => wil Return Range From 0 To 499
            //var Result = Enumerable.Range(0, 500);
            //foreach (var result in Result) 
            //{
            //    Console.Write($"{result} ");
            //}


            /* Repeat Operator */

            // Will Repeat number 2  => 50 
            //var Result = Enumerable.Repeat(2, 50);
            //foreach (var result in Result)
            //{
            //    Console.Write($"{result} ");
            //}

            /* empty Operator */

            //var Result = Enumerable.Empty<Product>();
            //foreach (var result in Result)
            //{
            //    Console.Write($"{result} ");
            //}

            #endregion

            #region Set Operator
            /*Union*/     //Without Dublication 
                          //var Sqn01 = Enumerable.Range(0, 100);
                          //var Sqn02 = Enumerable.Range(50, 149);
                          //var Result = Sqn01.Union(Sqn02);
                          //foreach (var result in Result)
                          //{
                          //    Console.Write($"{ result} , ");
                          //}


            /*Concat [UnionAll]*/   // With dublication
                                    //var Sqn01 = Enumerable.Range(0, 100);
                                    //var Sqn02 = Enumerable.Range(50, 149);
                                    //var Result = Sqn01.Concat(Sqn02);
                                    //foreach (var result in Result)
                                    //{
                                    //    Console.Write($"{result} , ");
                                    //}

            /*Distincit*/

            //var Sqn01 = Enumerable.Range(0, 100);
            //var Sqn02 = Enumerable.Range(50, 149);
            //var Result = Sqn01.Concat(Sqn02);
            //Result = Result.Distinct();
            //foreach (var result in Result)
            //{
            //    Console.Write($"{result} , ");
            //}

            ///*Interset*/ //return  the numbers in thr fist sequence and in the second sequence
            //var Sqn01 = Enumerable.Range(0, 100);
            //var Sqn02 = Enumerable.Range(50, 149);
            //var Result = Sqn01.Intersect(Sqn02);
            //foreach (var result in Result)
            //{
            //    Console.Write($"{result} , ");
            //}

            /*Except*/  // Return Element There in Sequence 1 and not in Sequence 2
                        //var Sqn01 = Enumerable.Range(0, 100);
                        //var Sqn02 = Enumerable.Range(50, 149);
                        //var Result = Sqn01.Except(Sqn02);
                        //foreach (var result in Result)
                        //{
                        //    Console.Write($"{result} , ");
                        //}
            #endregion

            #region Quantifier Operator
            //var sq01 = Enumerable.Range(0, 100);
            //var sq02= Enumerable.Range(0, 1001);

            //Console.WriteLine(sq01.Any());
            //Console.WriteLine(sq01.Any(P => P>10));
            //Console.WriteLine(sq01.All(P=>P ==0));
            //Console.WriteLine(sq01.SequenceEqual(sq02));
            #endregion

            #region Zipping Operator
            // string[] Names = { "Hesham", "Ahmed", "Hassan", "Ali" };
            // int[] numbers = Enumerable.Range(1,10).ToArray();
            // char[] Characters = { 'A', 'B', 'C', 'D' };
            // //var Result = Names.Zip(numbers); // This is the first overload
            // //var Result =Names.Zip(numbers,(name,number)=>new {Name = name ,Number = number});
            //var  Result =Names.Zip(numbers,Characters);
            // foreach (var item in Result)
            // { Console.WriteLine(item); }
            #endregion

            #region Grouping Operators
            var result = from p in ListGenerator.ProductList
                         group p by p.Category;

            foreach (var c in result)
            {
                Console.WriteLine(c.Key);
                foreach
                    (var c2 in c)
                {
                    Console.WriteLine($"                   {c2}");
                }
            }
            #endregion
        }
    }
}
