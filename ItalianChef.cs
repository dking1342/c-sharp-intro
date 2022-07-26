namespace csharp1
{
  class ItalianChef : Chef
  {
    public void MakePasta()
    {
      Console.WriteLine("the chef makes pasta");
    }
    public override void MakeSpecialDish()
    {
      Console.WriteLine("the italian chef makes pizza");
    }
  }
}