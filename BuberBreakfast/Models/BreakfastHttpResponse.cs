using System.Net;
using BuberBreakfast.Models;

namespace BuberBreakfast.Models;

public class BreakfastHttpResponse
{
  public DateTime Timestamp { get; set;}
  public int StatusCode { get; set; }
  public bool Success { get; set; }
  public string Message { get; set; }
  public List<Breakfast> Data { get; set; }

  public BreakfastHttpResponse(
    DateTime timestamp,
    int statusCode,
    bool success,
    string message,
    List<Breakfast> data
  )
  {
    Timestamp = timestamp;
    StatusCode = statusCode;
    Success = success;
    Message = message;
    Data = data;
  }
}