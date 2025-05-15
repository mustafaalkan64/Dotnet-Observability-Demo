using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnet_observability_demo.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private static readonly ActivitySource ActivitySource = new("MyDotNet9Api");

    [HttpGet]
    public IActionResult Get()
    {
        using var activity = ActivitySource.StartActivity("WeatherForecast");
        activity?.SetTag("custom.tag", "observability-demo");

        var temp = new Random().Next(-10, 35);
        return Ok(new { Status = "OK", Temperature = temp, Time = DateTime.UtcNow });
    }

}
