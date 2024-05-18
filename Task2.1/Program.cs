class Program 
{
    static void Main(string[] args) 
    {
        long num = 10;

        List<int> factorialNums = new List<int>();
        for (int i = 1; i <= num ; i++) 
        {
            factorialNums.Add(i);
        }

        long factorial = factorialNums.Aggregate((x, y) => x * y);
        Console.WriteLine(factorial);
    }
}