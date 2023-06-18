public class Library
{
    private List<Book> books;
    private List<Person> persons;

    public Library()
    {
        books = new List<Book>();
        persons = new List<Person>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added into the library.");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine("Book removed from the library.");
    }

    public void AddPerson(Person person)
    {
        persons.Add(person);
        Console.WriteLine("Person added.");
    }

    public void RemovePerson(Person person)
    {
        persons.Remove(person);
        Console.WriteLine("Person removed.");
    }

    public void EditPerson(Person person)
    {
        Console.WriteLine("Editing person information.");
        Console.WriteLine("Enter the new name:");
        string newName = Console.ReadLine();
        person.Name = newName;
        Console.WriteLine($"Person {person} information updated to {newName}.");
    }


    public void BorrowBook(Person person, Book book)
    {
        Console.WriteLine($"{person.Name} is borrowing {book.Title}.");
    }

    public void ReturnBook(Person person, Book book)
    {
        Console.WriteLine($"{person.Name} is returning {book.Title}.");
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}
