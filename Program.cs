namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // creating a new book object with constructor
          Book book1 = new Book("lotr","kavooce",400);

          Console.WriteLine($"Title: {book1.title}");
          Console.WriteLine($"Author: {book1.author}");
          Console.WriteLine($"Pages: {book1.pages}");
        }

    }
}