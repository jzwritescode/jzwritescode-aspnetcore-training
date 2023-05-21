using Microsoft.AspNetCore.Mvc;

namespace ContossoPizza.Controllers;

/// <summary>
/// JEZ:  Sample class using weather forecasting.  
/// JEZ:  IMPORTANT NOTE:  Inherit from "ControllerBase" instead of
/// "Controller" because "Controller" designed for web page views.
/// 
/// JEZ:  "ApiController" enables Web API functionality/behavior.
/// 
/// JEZ:  "Route("[controller]") 
///     - defines routing (class name without "Controller", all lowercase)
/// </summary>
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// JEZ:  Gets weather forecast and returns an array that will
    /// be converted into JSON.
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
