namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // math is a class
          // math has methods
          // methods use the static attribute 
          // allows us to not make an instance of the math class
          Console.WriteLine(Math.Sqrt(144));

          UsefulTools.greet("kavooce"); // no need to instatiate new UsefulTools object
        }

    }
}