using BuberBreakfasts.Models;
namespace BuberBreakfasts.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
  // normally would save to db
  private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
  public void CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
    
  }
  public Breakfast GetBreakfast(Guid id)
  {
    return _breakfasts[id];
  }

  public void UpsertBreakfast(Breakfast breakfast)
  {
    _breakfasts[breakfast.Id] = breakfast;
  }

  public void DeleteBreakfast(Guid id)
  {
    _breakfasts.Remove(id);
  }
}