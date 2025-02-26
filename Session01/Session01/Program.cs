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

        }
    }
}
