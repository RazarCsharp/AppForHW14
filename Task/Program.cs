namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>()
            {
            new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
            new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
            new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
            new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
            new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
            new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };
            var sortedContacts = phoneBook
                 .OrderBy(s => s.Name)
                 .ThenBy(s => s.LastName);

            foreach (var contact in sortedContacts)
                Console.WriteLine("Name : {0}  LastName : {1} Phone number : {2} Email : {3}", contact.Name, contact.LastName, contact.PhoneNumber, contact.Email);
        }
    }
}