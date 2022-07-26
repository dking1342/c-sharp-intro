namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // 2d array
          int[,] numberGrid = {
            { 2,5},
            { 5,6},
            { 7,9},
          };

          // access the value in the 2d array using this syntax
          Console.WriteLine(numberGrid[0,1]);

          // all other array methods can be used with 2d arrays
          // can have infinite dimensional arrays

          // another way to create a 2d array which can be set later
          int[,] myArray = new int[2,3];
        }

    }
}