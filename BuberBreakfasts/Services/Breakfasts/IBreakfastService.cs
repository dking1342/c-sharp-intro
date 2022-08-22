using BuberBreakfasts.Models;
namespace BuberBreakfasts.Services.Breakfasts;

public interface IBreakfastService
{
  void CreateBreakfast(Breakfast breakfast);
  Breakfast GetBreakfast(Guid id);
  void UpsertBreakfast(Breakfast breakfast);
  void DeleteBreakfast(Guid id);

}