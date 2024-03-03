var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello-world", () =>
{
    return "Hello world";
});

if(builder.Environment.IsProduction())
{
    app.Run("http://localhost:80");
    return;
}

app.Run();