using System.Collections.Generic;

namespace Pd.MediatrPipelines.Application.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastResponse
    {
        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }
    }
}