var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/", () =>
{
    return "Hello this is Main URL";
});

app.MapGet("/get", () =>  //GET API
{
    return "Hello I'm Get Method";
});

app.MapPost("/post", () => //POST API
{
    return "Hello I'm Post Method";
});

app.MapPut("/put", () =>  //PUT API
{
    return "Hello I'm PUT Method";
});

app.MapDelete("/delete", () => //DELETE API
{
    return "Hello I'm Delete Method";
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
