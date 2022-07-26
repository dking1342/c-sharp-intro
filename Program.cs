namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {   
          // storing user inputs into variables then display it later
          Console.Write("Enter your name: ");
          string name = Console.ReadLine()!;
          Console.Write("Enter your age: ");
          int age = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine($"Username: {name}");
          Console.WriteLine($"Age: {age}");
        }
    }
}