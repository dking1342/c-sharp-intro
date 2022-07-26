namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // creating a new movie
          Movie avengers = new Movie("The Avengers","Josh Whedon","PG-13");
          Movie shrek = new Movie("Shrek","Adam Adamson", "PG");

          avengers.Rating = "R";
          Console.WriteLine(avengers.Rating);
          
        }

    }
}