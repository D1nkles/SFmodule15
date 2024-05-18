class Program 
{
    static void Main(string[] args) 
    {
        int num;
        int numsCount;
        int numsSum;
        int numMax;
        int numMin;
        double numAverage;
        var numsList = new List<int>();

        while (true) 
        {
            Console.Write("Введите целое число с клавиатуры: ");
            num = int.Parse(Console.ReadLine());

            numsList.Add(num);

            Console.WriteLine($"Кол-во чисел в списке: {numsList.Count}");
            Console.WriteLine($"Сумма чисел в списке: {numsList.Sum()}");
            Console.WriteLine($"Максимальное число в списке: {numsList.Max()}");
            Console.WriteLine($"Минимальное число в списке: {numsList.Min()}");
            Console.WriteLine($"Среднее число в списке: {numsList.Average()}");
        }
    }
}