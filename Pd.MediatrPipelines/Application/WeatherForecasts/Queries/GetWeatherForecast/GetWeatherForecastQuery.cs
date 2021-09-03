using MediatR;

namespace Pd.MediatrPipelines.Application.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQuery : IRequest<GetWeatherForecastResponse>
    {
    }
}