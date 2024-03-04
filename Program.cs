var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello world";
});

if(builder.Environment.IsProduction())
{
    app.Run("http://localhost:80");
    return;
}

app.Run();