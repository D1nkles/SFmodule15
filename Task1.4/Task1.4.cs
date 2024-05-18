class Program 
{
    static void Main(string[] args) 
    {
        string word1 = "нолзщфл";
        string word2 = "пошцфоз";

        var commonLetters = word1.Intersect(word2);

        foreach (var letter in commonLetters) 
        {
            Console.Write(letter);
        }
    }
}