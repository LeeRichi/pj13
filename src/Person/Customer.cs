public class Customer : Person, IBorrowable
{
    public void Borrow(Book book)
    {
        Console.WriteLine($"Borrowing a book {book}");
    }

    public void Return(Book book)
    {
        Console.WriteLine($"Returning a book {book}");
    }
}
