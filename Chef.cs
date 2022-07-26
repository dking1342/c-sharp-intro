namespace csharp1
{
  class Chef
  {
    public void MakeChicken()
    {
      Console.WriteLine("The chef makes chicken");
    }
    public void MakeSalad()
    {
      Console.WriteLine("The chef makes salad");
    }
    // virtual attribute means that it can be overwritten in child class
    public virtual void MakeSpecialDish()
    {
      Console.WriteLine("The chef makes the bbq ribs");
    }
  }
}