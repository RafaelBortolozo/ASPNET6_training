var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Hello world!");
});

app.MapGet("name/{name}", (string name) => {
    return Results.Ok($"Hello {name}!");
});

app.MapPost("/", (User user) => {
    return Results.Ok(user);
});


app.MapGet("/banana", () => "Hello Banana!");

app.Run();

public class User{
    public int Id { get; set; }
    public string username { get; set; }
}