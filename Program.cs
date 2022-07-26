namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // creating a new student
          Student student1 = new Student("Jim","Business",2.8);
          Student student2 = new Student("Pam", "Art", 3.6);

          // calling the methods
          Console.WriteLine(student1.hasHonors());
          Console.WriteLine(student2.hasHonors());
        }

    }
}