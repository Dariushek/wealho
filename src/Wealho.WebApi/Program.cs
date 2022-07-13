using Wealho.WebApi;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

WebApplication app = builder.Build();

app.ConfigureMiddlewares();

app.Run();