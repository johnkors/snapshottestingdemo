var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/person", () => new {
    firstName = "John", lastName = "Korsnes"
});
app.Run();

public partial class Program { }

