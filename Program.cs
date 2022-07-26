namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {   
          Console.Write("Enter your name: ");
          string user = Console.ReadLine()!;
          Console.Write("Enter your age: ");
          int age = Convert.ToInt32(Console.ReadLine());

          greet(user, age); // call the method inside the other method
          greet("Jack");
        }

        // methods - block of code to perform a task
        // first keyword denotes the availability of the method (public, private, static, abstract, etc)
        // second keyword denotes the return value (void, string, int, etc)
        // third keyword in the name of the method
        // fourth keyword is the parameter if there is one. the parameter must be data typed
        // default value can be given to a parameter if required
        static void greet(string name, int age = 30){
          Console.WriteLine($"howdy {name}!"); // takes in the parameter within the method
          Console.WriteLine($"you are {age} years old and you are so young!"); // takes in the parameter within the method
        }
    }
}