using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;

namespace BuberBreakfast.Controllers;

public class ErrorsController : ControllerBase
{

  [Route("/error-handler")]
  public IActionResult ErrorHandler()
  {
      BreakfastHttpResponse response = new BreakfastHttpResponse(
      DateTime.UtcNow,
      400,
      false,
      "Bad request",
      new List<Breakfast>()
    );

    return BadRequest(response);
  }

  [Route("/error")]
  public IActionResult Error()
  {
    return Problem();
  }
}