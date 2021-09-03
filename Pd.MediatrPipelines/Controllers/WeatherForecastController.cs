using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pd.MediatrPipelines.Application.WeatherForecasts.Queries.GetWeatherForecast;

namespace Pd.MediatrPipelines.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await Mediator.Send(new GetWeatherForecastQuery());

            return Ok(response);
        }
    }
}
