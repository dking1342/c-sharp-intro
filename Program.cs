namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {   
          double power1 = cube(2);
          double power2 = cube(4);
          double power3 = cube(7);

          Console.WriteLine(power1);
          Console.WriteLine(power2);
          Console.WriteLine(power3);
        }

        static double cube(double num = 1){
          return Math.Pow(num, 3);
        }
    }
}