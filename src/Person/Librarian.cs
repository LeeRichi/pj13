public class Librarian : Person
{
    private List<Book> books;

    public Librarian()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book is successfully added into library");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine("Book is deleted from library");
    }

    public void EditBook(Book book, string newTitle, string newAuthor)
    {
        Book bookToUpdate = books.FirstOrDefault(b => b.ISBN == book.ISBN);

        if (bookToUpdate != null)
        {
            bookToUpdate.Title = newTitle;
            bookToUpdate.Author = newAuthor;
            Console.WriteLine($"Book information updated.");
        }
        else
        {
            Console.WriteLine("Book not found in the library.");
        }
    }
}