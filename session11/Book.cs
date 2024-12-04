class Book
{
    public string bookId;
    public string bookName;
    public string author;
    public double price;
    public Book(string bookId, string bookName, string author, double price)
    {
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }
    public void showBook()
    {
        Console.WriteLine($"BookId: {this.bookId}, BookName: {this.bookName}, Author: {this.author}, Price: {this.price}");
    }
}