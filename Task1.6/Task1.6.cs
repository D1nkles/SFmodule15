class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введите произвольную строку символов...");
        string text = Console.ReadLine();

        List<char> punctuation = new List<char>{' ', ',' , '.', '!', ';', ':', '?'};

        var uniqueLetters = text.Distinct();
        var noPunctuation = uniqueLetters.Except(punctuation);

        foreach (var letter in noPunctuation) 
        {
            Console.Write(letter + " ");
        }
    }
}