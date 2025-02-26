namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            List<int> OddNums = list.Where(num => num%2==0).ToList();
            foreach (int num in OddNums) { Console.WriteLine(num); }
        }
    }
}
