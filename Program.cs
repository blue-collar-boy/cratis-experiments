using Cratis.Chronicle;

var builder = WebApplication.CreateBuilder(args);

// Issue #1 
builder.Services.AddSingleton<IEventStoreNamespaceResolver>(new DefaultEventStoreNamespaceResolver());

builder.AddCratisChronicle(options => options.EventStore = "Quickstart");
var app = builder.Build();


app.UseCratisChronicle();

// Issue #2 when calling test/add endpoint
app.MapPost(
    "test/add",
    () =>
    {
        // Works
        return Results.Ok();
    }
);

app.Run();
