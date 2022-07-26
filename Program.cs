namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // while loops
          // basic syntax
          // while (condition) 
          // {
          //   // code block to be executed
          // }

          // example using a while loop
          int i = 0;
          while (i < 5) 
          {
            Console.WriteLine(i);
            i++;
          }

          // do while - executes at least one time then loops depending on condition
          // syntax
          // do 
          // {
          //   // code block to be executed
          // }
          // while (condition);

          // example of a do while loop
          int index = 0;
          do 
          {
            Console.WriteLine(index);
            index++;
          }
          while (index < 5);

          

        }

    }
}