namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // structure of an if statement
          if (4 > 5) 
          {
            // block of code to be executed if the condition is True
          }

          // testing numbers
          if (20 > 18) 
          {
            Console.WriteLine("20 is greater than 18");
          }

          // testing variables
          int x = 20;
          int y = 18;
          if (x > y) 
          {
            Console.WriteLine("x is greater than y");
          }

          // if/else structure
          if (5 == 5)
          {
            // block of code to be executed if the condition is True
          } 
          else 
          {
            // block of code to be executed if the condition is False
          }

          // example with time of day
          int time = 20;
          if (time < 18) 
          {
            Console.WriteLine("Good day.");
          } 
          else 
          {
            Console.WriteLine("Good evening.");
          }
          // Outputs "Good evening."

          // if/else if/else structure
          // if (condition)
          // {
          //   // block of code to be executed if condition1 is True
          // } 
          // else if (condition) 
          // {
          //   // block of code to be executed if the condition1 is false and condition2 is True
          // } 
          // else
          // {
          //   // block of code to be executed if the condition1 is false and condition2 is False
          // }

          // example with if/else if/else
          int hour = 22;
          if (hour < 10) 
          {
            Console.WriteLine("Good morning.");
          } 
          else if (hour < 20) 
          {
            Console.WriteLine("Good day.");
          } 
          else 
          {
            Console.WriteLine("Good evening.");
          }
          // Outputs "Good evening."

          // short hand structure -- ternary operator
          // variable = (condition) ? expressionTrue :  expressionFalse;
          // example of ternary
          int timeOfDay = 20;
          string result = (timeOfDay < 18) ? "Good day." : "Good evening.";
          Console.WriteLine(result);

          // logical operators can be included as well
          bool isMale = true;
          bool isTall = false;

          if( isMale && isTall){
            Console.WriteLine("you are male and you are tall");
          } else if( isMale || isTall){
            Console.WriteLine("you are either male or tall");
          } else {
            Console.WriteLine("you are neither male nor tall");
          }
        }

    }
}