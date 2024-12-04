class Library
{
    public string libraryId;
    public string libraryName;
    public List<Book> bookInLibrary;

    public Library(string libraryId, string libraryName)
    {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.bookInLibrary = new List<Book>();
    }
    public void addBook(Book book)
    {
        bookInLibrary.Add(book);
        Console.WriteLine($"Book {book.bookName} added to the library {libraryName}");
    }
    public void showBook()
    {
        Console.WriteLine($"\n ----Books in the Library {libraryName}----");
        foreach (Book book in bookInLibrary)
        {
            book.showBook();
        }
    }
    public void findBook(string bookId)
    {
        foreach (Book books in bookInLibrary)
        {
            if (books.bookId == bookId)
            {
                books.showBook();
                return;
            }
        }
        Console.WriteLine($"Book with id {bookId} is not found in the library {libraryName}.");
    }
}