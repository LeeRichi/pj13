public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Comic OnePiece_ep1 = new Comic
        {
            Title = "One Piece_ep1",
            Author = "尾田榮一郎",
            ISBN = "1234-0000",
            PublicationYear = 1996,
            Artist = "尾田榮一郎"
        };

        Novel Game_of_Thrones = new Novel
        {
            Title = "Game of Thrones",
            Author = "George R. R. Martin",
            ISBN = "5678-9999",
            PublicationYear = 1986,
            Genre = "Drama"
        };

        TextBook Introduction_to_Algorithms = new TextBook
        {
            Title = "Introduction to Algorithms",
            Author = "Thomas H. Cormen",
            ISBN = "978-0262533058",
            PublicationYear = 2009,
            MaxPrintPages = 250
        };

        ResearchPaper A_Brief_History_of_Time = new ResearchPaper
        {
            Title = "A Brief History of Time",
            Author = "Stephen Hawking",
            ISBN = "978-0553380163",
            PublicationYear = 1998,
            MaxPrintPages = 250
        };

        library.AddBook(OnePiece_ep1);
        library.AddBook(Game_of_Thrones);
        library.AddBook(Introduction_to_Algorithms);
        library.AddBook(A_Brief_History_of_Time);

        Customer Lee_Chi = new Customer
        {
            Name = "Lee Chi",
            ID = 008
        };

        Librarian Olen = new Librarian
        {
            Name = "Olen",
            ID = 002
        };

        library.AddPerson(Lee_Chi);
        library.AddPerson(Olen);

        Lee_Chi.Borrow(OnePiece_ep1);
        Lee_Chi.Borrow(Game_of_Thrones);
        Lee_Chi.Return(Game_of_Thrones);

        Olen.AddBook(OnePiece_ep1);
        Olen.RemoveBook(Game_of_Thrones);
        Olen.EditBook(Introduction_to_Algorithms, "Introduction_to_Programming", "Lee_Chi");

        Console.WriteLine();
        foreach (Book book in library.GetBooks())
        {
            book.PrintInfo();
            Console.WriteLine();
        }
    }
}
