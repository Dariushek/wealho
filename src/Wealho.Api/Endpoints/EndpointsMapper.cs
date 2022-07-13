namespace Wealho.Endpoints;

public static class EndpointsMapper
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.GetWeatherForecast();
    }
}