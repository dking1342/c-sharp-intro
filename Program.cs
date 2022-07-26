namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // for loops
          // syntax
          // for (statement 1; statement 2; statement 3) 
          // {
          //   // code block to be executed
          // }

          // example a for loop
          for (int i = 0; i < 5; i++) 
          {
            Console.WriteLine(i);
          }
          // example with a different increment value
          for (int i = 0; i <= 10; i = i + 2) 
          {
            Console.WriteLine(i);
          }

          // foreach loop
          // syntax
          // foreach (type variableName in arrayName) 
          // {
          //   // code block to be executed
          // }

          // example of a foreach loop
          string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
          foreach (string i in cars) 
          {
            Console.WriteLine(i);
          }

        }

    }
}