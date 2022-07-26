namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // exception handling

          try
          {
            Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( num1 / num2 );
          }
          catch (System.DivideByZeroException e) // you can be specific for the exception for generic and add more catch blocks
          {
            Console.WriteLine(e.Message);
          } 
          catch (System.FormatException e)
          {
            Console.WriteLine(e.Message);
          }
          finally
          {
            Console.WriteLine("finally block executed");
          }

        }

    }
}