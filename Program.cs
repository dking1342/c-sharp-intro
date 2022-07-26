namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // inheritance
          // parent class
          Chef chef = new Chef();
          chef.MakeChicken();
          chef.MakeSpecialDish();

          // child class
          ItalianChef italianChef = new ItalianChef();
          italianChef.MakeSalad();
          italianChef.MakePasta();
          italianChef.MakeSpecialDish();
        }

    }
}