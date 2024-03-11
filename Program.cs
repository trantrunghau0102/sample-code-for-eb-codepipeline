using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.Configure<ForwardedHeadersOptions>(c =>
    {
        c.ForwardedHeaders =
            ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    });
}

var app = builder.Build();
{
    app.UseForwardedHeaders();
    app.MapGet("/", () =>
    {
        return "Hello TTH";
    });
    app.Run();
}
