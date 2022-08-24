using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net;
using System;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class BreakfastController : ControllerBase
{
  
  private readonly IBreakfastService _breakfastService;

  public BreakfastController(IBreakfastService breakfastService)
  {
    _breakfastService = breakfastService;
  }

  [HttpPost]
  public IActionResult CreateBreakfast(CreateBreakfastRequest request)
  {
    var breakfast = new Breakfast(
      Guid.NewGuid(),
      request.Name,
      request.Description,
      request.StartDateTime,
      request.EndDateTime,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );

    // save to db
    var dbResponse = _breakfastService.CreateBreakfast(breakfast);
    BreakfastHttpResponse response = new BreakfastHttpResponse(
      DateTime.UtcNow,
      201,
      true,
      "New breakfast created",
      new List<Breakfast>()
    );

    if(dbResponse?.Count > 0)
    {
      response.Data = dbResponse;
      return Created("",response);
    }
    else 
    {
      response.StatusCode = 400;
      response.Success = false;
      response.Message = "Server Error";

      return BadRequest(response);
    }

  }

  [HttpGet("{id:guid}")]
  public IActionResult GetBreakfast(Guid id)
  {
    List<Breakfast> getBreakfastResult = _breakfastService.GetBreakfast(id);
    BreakfastHttpResponse response = new BreakfastHttpResponse(
      DateTime.UtcNow,
      200,
      true,
      "Breakfast fetched",
      new List<Breakfast>()
    );

    if (getBreakfastResult?.Count > 0)
    {
      response.Data = getBreakfastResult;
      return Ok(response);
    }
    else 
    {
      response.StatusCode = 404;
      response.Success = false;
      response.Message = "Invalid breakfast";

      return NotFound(response);
    }
  }

  [HttpPut("{id:guid}")]
  public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
  {
    var breakfast = new Breakfast(
      id,
      request.Name,
      request.Description,
      request.StartDateTime,
      request.EndDateTime,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );

    List<Breakfast> dbResponse = _breakfastService.UpsertBreakfast(id, breakfast);
    BreakfastHttpResponse response = new BreakfastHttpResponse(
      DateTime.UtcNow,
      200,
      true,
      "Breakfast updated",
      new List<Breakfast>()
    );

    if(dbResponse?.Count > 0)
    {
      response.Data = dbResponse;
      return Ok(response);
    }
    else 
    {
      response.StatusCode = 400;
      response.Success = false;
      response.Message = "Server Error";

      return BadRequest(response);
    }

    // return 201 if new breakfast was created
    // return NoContent();
  }

  [HttpDelete("{id:guid}")]
  public IActionResult DeleteBreakfast(Guid id)
  {
    bool dbResponse = _breakfastService.DeleteBreakfast(id);
    BreakfastHttpResponse response = new BreakfastHttpResponse(
      DateTime.UtcNow,
      202,
      true,
      "Breakfast deleted",
      new List<Breakfast>()
    );

    if(dbResponse)
    {
      return Accepted(response);
    }
    else 
    {
      response.StatusCode = 400;
      response.Success = false;
      response.Message = "Bad Request";

      return BadRequest(response); 
    }
    // return NoContent();
  }
}