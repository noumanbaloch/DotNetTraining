using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace DotNetTrainin.API.Controllers;
[ApiController]
public class WeatherForecastController : ApiController
{

    public async Task<IActionResult> GetSomething()
    {
        return (IActionResult)Ok(200);
    }
}
