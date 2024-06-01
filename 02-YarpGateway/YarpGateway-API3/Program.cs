var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api3", () => "Hello World!");

app.Run();