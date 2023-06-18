public class Novel : Book
{
    public string? Genre { get; set; }
    public override bool CanBorrow { get; set; } = true;
    public override bool CanPrintPages => false;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Genre: {Genre}");
    }

    public void Borrow()
    {
        Console.WriteLine("Borrowing a novel");
    }

    public void Return()
    {
        Console.WriteLine("Returning a novel");
    }
}
