using BuberBreakfast.Models;
// using BuberBreakfast.ServiceErrors;
using System;
using System.Collections.Generic;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
  // normally would save to db
  
  private static readonly Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();
  public List<Breakfast> CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);

    List<Breakfast> breakfastList = new List<Breakfast>();
    breakfastList.Add(breakfast);
    return breakfastList;
  }
  public List<Breakfast> GetBreakfast(Guid id)
  {
    // return _breakfasts[id];
    List<Breakfast> breakfastList = new List<Breakfast>();

    if (_breakfasts.TryGetValue(id, out Breakfast? breakfast))
    {
      breakfastList.Add(breakfast);
    }
    return breakfastList;
    
  }

  public List<Breakfast> UpsertBreakfast(Guid id, Breakfast breakfast)
  {
    _breakfasts[breakfast.Id] = breakfast;

    List<Breakfast> breakfastList = new List<Breakfast>();
    if (_breakfasts.TryGetValue(id, out Breakfast? breakfastDict))
    {
      breakfastList.Add(breakfastDict);
    }
    return breakfastList;
  }

  public bool DeleteBreakfast(Guid id)
  {
    if (_breakfasts.TryGetValue(id, out Breakfast? breakfastDict))
    {
      _breakfasts.Remove(id);
      return true;
    }
    return false;
  }
}