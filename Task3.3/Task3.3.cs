class Program 
{
    static void Main(string[] args) 
    {
        var phoneBook = new List<Contact>();

        
        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

        var groupedBook = phoneBook.GroupBy(c => c.Email.Contains("example"));
        
        foreach (var group in groupedBook) 
        {
            if(group.Key == true) 
            {
                Console.WriteLine("Фейковые адреса: ");
                foreach (var contact in group)
                {
                    Console.WriteLine(contact.Email);
                }
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Настоящие адреса:");
                foreach (var contact in group)
                {
                    Console.WriteLine(contact.Email);
                }
            }
        }
    }
}

public class Contact
{
    public Contact(string name, long phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public String Name { get; set; }
    public String LastName { get; set; }
    public long Phone { get; set; }
    public String Email { get; set; }
    
}