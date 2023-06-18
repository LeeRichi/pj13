public abstract class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? ISBN { get; set; }
    public int PublicationYear { get; set; }
    public abstract bool CanBorrow { get; set; }
    public virtual bool CanPrintPages { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}
