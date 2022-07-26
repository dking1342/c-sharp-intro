namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
          string phrase = "howdy"; // string is a series of characters
          char letter = 'D'; // single quotation and only one character
          int score = 7; // whole numbers
          double temperature = 45.5D; // decimal numbers
          float gpa = 3.75F; // float number
          bool isAvailable = true; // true or false 

          Console.WriteLine($"String: {phrase}");
          Console.WriteLine($"Char: {letter}");
          Console.WriteLine($"Int: {score}");
          Console.WriteLine($"Double: {temperature}");
          Console.WriteLine($"Float: {gpa}");
          Console.WriteLine($"Boolean: {isAvailable}");
        }
    }
}