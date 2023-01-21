namespace LibraryManagment.Models
{
public class Book
{
    public int BookId { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public DateTime PublisherAt { get; set; }
    public int Version { get; set; }
}
}