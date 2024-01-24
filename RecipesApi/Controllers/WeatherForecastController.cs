using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast;

[ApiController]
[Route("/api/misc/weather")] // [controller] renders as name of class minus "Controller" e.g. WeatherForecast
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

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)), // for the next 5 days
            TemperatureC = Random.Shared.Next(-20, 55), // random temp
            Summary = Summaries[Random.Shared.Next(Summaries.Length)] // random summary
        })
        .ToArray();
    }
}
