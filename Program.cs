var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AI Resume Analyzer API is running");

app.Run();
