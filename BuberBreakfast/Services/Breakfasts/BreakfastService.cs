using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using System;
using System.Collections.Generic;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
  // normally would save to db
  
  private static readonly Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();
  public void CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
    
  }
  public Breakfast GetBreakfast(Guid id)
  {
    if (_breakfasts.TryGetValue(id, out Breakfast breakfast))
    {
      return breakfast;
    }

    return new Breakfast();
    
    // return _breakfasts[id];

    // if (_breakfasts.TryGetValue(id, out var breakfast))
    // {
    //   return breakfast;
    // }

    // return Errors.Breakfast.NotFound;
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