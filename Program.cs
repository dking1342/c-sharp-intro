namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
          // numbers divided into two groups - Integers (whole numbers) and Floats (decimal)

          // creating integer variables
          int num1 = 10;
          int num2 = 5;

          // can do mathematical operations
          Console.WriteLine(num1 + num2);

          // creating long variable
          long longNum = 15000000000L;
          Console.WriteLine(longNum);

          // creating float variable
          float floatNum = 5.75F;
          Console.WriteLine(floatNum);          

          // creating double variable
          double doubleNum = 19.99D;
          Console.WriteLine(doubleNum);

          // math class
          // math class has many methods for mathematical operations
          Console.WriteLine(Math.Abs(num1)); // absolute value      
          Console.WriteLine(Math.Sqrt(num2)); // square root 

          // math operators
          // Operator	Name	Description	Example
          // +	Addition	Adds together two values	x + y	
          // -	Subtraction	Subtracts one value from another	x - y	
          // *	Multiplication	Multiplies two values	x * y	
          // /	Division	Divides one value by another	x / y	
          // %	Modulus	Returns the division remainder	x % y	
          // ++	Increment	Increases the value of a variable by 1	x++	
          // --	Decrement	Decreases the value of a variable by 1	x--


          // assignment operators
          // Operator	Example	Same As	
          // =	x = 5	x = 5	
          // +=	x += 3	x = x + 3	
          // -=	x -= 3	x = x - 3	
          // *=	x *= 3	x = x * 3	
          // /=	x /= 3	x = x / 3	
          // %=	x %= 3	x = x % 3	
          // &=	x &= 3	x = x & 3	
          // |=	x |= 3	x = x | 3	
          // ^=	x ^= 3	x = x ^ 3	
          // >>=	x >>= 3	x = x >> 3	
          // <<=	x <<= 3	x = x << 3     

          // comparison operators 
          // Operator	Name	Example
          // ==	Equal to	x == y	
          // !=	Not equal	x != y	
          // >	Greater than	x > y	
          // <	Less than	x < y	
          // >=	Greater than or equal to	x >= y	
          // <=	Less than or equal to	x <= y          

          // logical operators
          // Operator	Name	Description	Example
          // && 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
          // || 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
          // !	Logical not	Reverse the result, returns false if the result is true   

        }
    }
}