class Program 
{
    static void Main(string[] args) 
    {
        var contacts = new List<Contact>()
        {
            new Contact() { Name = "Андрей", Phone = 79994500508 },
            new Contact() { Name = "Сергей", Phone = 799990455 },
            new Contact() { Name = "Иван", Phone = 79999675334 },
            new Contact() { Name = "Игорь", Phone = 8884994 },
            new Contact() { Name = "Анна", Phone = 665565656 },
            new Contact() { Name = "Василий", Phone = 3434 }
        };

        int correctNumbers = contacts.Count(s => s.Phone.ToString().Length == 11 && s.Phone.ToString().First() == '7');
        Console.WriteLine(correctNumbers);
    }

    public class Contact 
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public long Phone{ get; set; }
        public String Email { get; set; }
    }
}