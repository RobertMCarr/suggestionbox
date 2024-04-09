using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;
using SuggestionBox.Core;

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

string connectionString = "server=Jupiter;user=Robert;database=callisto;password=magicK12";

/*var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}*/


app.MapGet("/box/{id}", async context =>
{
    // Retrieve the ID from the route
    var id = context.Request.RouteValues["id"];
    Box box = null;

    using (var connection = new MySqlConnection(connectionString))
    {
        connection.Open();

        // Query to execute
        string query = "select * from boxes where box_id = " + id;

        using (var command = new MySqlCommand(query, connection))
        {
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Access data from the reader
                    // int id = reader.GetInt32(0); // Assuming the first column is an integer
                    //string name = reader.GetString(1); // Assuming the second column is a string


                    // Do something with the data
                    //Console.WriteLine($"ID: {id}, Name: {name}");
                    Console.WriteLine("success");
                }
            }
        }
    }

   // return box;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();