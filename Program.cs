namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // creating a new book object
          Book book1 = new Book();
          book1.title = "lotr";
          book1.author = "kavooce";
          book1.pages = 400;

          Console.WriteLine($"Title: {book1.title}");
          Console.WriteLine($"Author: {book1.author}");
          Console.WriteLine($"Pages: {book1.pages}");
        }

    }
}