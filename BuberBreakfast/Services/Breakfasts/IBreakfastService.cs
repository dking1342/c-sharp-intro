using BuberBreakfast.Models;
using System.Collections.Generic;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
  List<Breakfast> CreateBreakfast(Breakfast breakfast);
  List<Breakfast> GetBreakfast(Guid id);
  List<Breakfast> UpsertBreakfast(Guid id, Breakfast breakfast);
  bool DeleteBreakfast(Guid id);

}