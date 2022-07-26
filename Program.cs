namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {   
          // arrays
          // creating array variables for different data types
          string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
          Console.WriteLine(cars[0]);
          cars[0] = "Buick";
          Console.WriteLine(cars[0]);

          int[] ages = {10, 200, 30, 40};
          Console.WriteLine($"Ages length: {ages.Length}");
          Array.Sort(ages);

          Console.WriteLine($"Max age: {ages.Max()}");  // returns the largest value
          Console.WriteLine($"Min age: {ages.Min()}");  // returns the smallest value
          Console.WriteLine($"Age sum: {ages.Sum()}");  // returns the sum of elements

          // other ways to create an array
          // Create an array of four elements, and add values later
          string[] vehicles1 = new string[4];

          // Create an array of four elements and add values right away 
          string[] vehicles2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

          // Create an array of four elements without specifying the size 
          string[] vehicles3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

          // Create an array of four elements, omitting the new keyword, and without specifying the size
          string[] vehicles4 = {"Volvo", "BMW", "Ford", "Mazda"};

        }
    }
}