public class TextBook : Book
{
    public int MaxPrintPages { get; set; }
    public override bool CanBorrow { get; set; } = true;
    public override bool CanPrintPages => true;

    public override void PrintInfo()
    {
        base.PrintInfo();
    }

    public void Borrow()
    {
        Console.WriteLine("Borrowing a textbook");
    }

    public void Return()
    {
        Console.WriteLine("Returning a textbook");
    }

    public void PrintPages(int startPage, int endPage)
    {
        int totalPages = endPage - startPage + 1;

        if (totalPages <= MaxPrintPages)
        {
            Console.WriteLine($"Printing pages from {startPage} to {endPage}");
        }
        else
        {
            Console.WriteLine($"Printing pages beyond the allowed limit. Max Print Pages: {MaxPrintPages}");
        }
    }
}
