using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.AddCratisChronicle(options => options.EventStore = "Quickstart");
builder.Services.AddControllers();

// Apparently we need that
builder.Services.AddSingleton(new JsonSerializerOptions(JsonSerializerDefaults.Web));

var app = builder.Build();

app.UseCratisChronicle();
app.MapControllers();

app.MapGet("api/TestApi/test4/{id:guid}", (Guid id) =>
{
    // Works
    return Results.Ok("test5 " + id);
});

app.Run();
