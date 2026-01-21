var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// middleware
app.Use(async (context, next) =>
{
    // Check if the URL has ?key=123
    if (context.Request.Query["key"] == "123")
    {
        await next(); // Correct key! Let them in.
    }
    else
    {
        await context.Response.WriteAsync("Wrong Key! Access Denied."); // Stop them here.
    }
});

// THE DESTINATION
app.MapGet("/", () => "Hello! You found the secret page.");

app.Run();
