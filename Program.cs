namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
          // making string variables
          string football = "Denver Broncos";
          string hockey = "Colorado\nAvs";

          Console.WriteLine($"Football: {football}");
          Console.WriteLine($"Hockey: {hockey}");

          // length of string
          int footballLength = football.Length;
          int hockeyLength = hockey.Length;

          Console.WriteLine($"Football length: {footballLength}");
          Console.WriteLine($"Hockey length: {hockeyLength}");

          // modifying string
          Console.WriteLine(football.ToUpper()); // capitalizes string
          Console.WriteLine(football.ToLower()); // lowercase string
          Console.WriteLine(football.Contains("Denver")); // check if string contains search parameter
          Console.WriteLine(football.Equals("Detroit Tigers")); // checks for equality
          Console.WriteLine(football[0]); // find character of string by searching index value
          Console.WriteLine(football.IndexOf("e")); // finds index position of search parameter
          
        }
    }
}