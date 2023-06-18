// Derived class for Comic books
public class Comic : Book
{
    public string? Artist { get; set; }
    public override bool CanBorrow { get; set; } = true;
    public override bool CanPrintPages => false;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Artist: {Artist}");
    }

    public void Borrow()
    {
        Console.WriteLine("Borrowing a comic book");
    }

    public void Return()
    {
        Console.WriteLine("Returning a comic book");
    }
}
