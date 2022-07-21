var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Ema and Dare! Trying this without the del line");

app.Run();
