namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1,2,3,4,5,6};
            //List<int> OddNums = list.Where(num => num%2==0).ToList();
            //foreach (int num in OddNums) { Console.WriteLine(num); }

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var OddNumber =Enumerable.Where(list,num => num % 2 == 0);
            //foreach (var num in OddNumber)
            //{
            //    Console.Write($"{num} ");
            //}

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var OddNumber = list.Where(num => num % 2 == 0);
            foreach (int num in OddNumber)  {Console.WriteLine(num); }

        }
    }
}
