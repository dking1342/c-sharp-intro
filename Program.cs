namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
          // creating new variables
          // you can intentionally type the variable or it can be inferred
          string name = "Jack";
          int age = 30;

          // setting variable for later use
          string friend;
          friend = "Joe";

          Console.WriteLine($"There once was a man name {name} who had a friend named {friend}");
          Console.WriteLine($"He was {age} years old");
          name = "Jill"; // variables can be modified
          Console.WriteLine($"He really liked the name {name}");
          Console.WriteLine($"But he didn't like being {age}");

          // declaring variables that do not change value with const
          const string location = "Japan"; // this variable cannot be overwritten
          Console.WriteLine($"{name} lives in {location}");

          // declaring variables with different data types
          int myNum = 5;
          double myDoubleNum = 5.99D;
          char myLetter = 'D';
          bool myBool = true;
          string myText = "Hello";
          Console.WriteLine(myNum);
          Console.WriteLine(myDoubleNum);
          Console.WriteLine(myLetter);
          Console.WriteLine(myBool);
          Console.WriteLine(myText);
        }
    }
}