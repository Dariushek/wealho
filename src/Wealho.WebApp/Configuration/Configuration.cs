using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Wealho;

public static class Configuration
{
    public static void ConfigureServices(this WebAssemblyHostBuilder builder)
    {
        string baseUrl = builder.Configuration["ApiBaseUrl"] ?? throw new ApplicationException("Missing configuration.");
        builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new(baseUrl)});
    }
}