var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/CalculateTimeAngle", (int hour, int minute) =>
{
    if (hour < 0 || hour > 12)
    {
        return Results.BadRequest("hour must be between 0 and 12");
    }

    if (minute < 0 || minute > 59)
    {
        return Results.BadRequest("minute must be between 0 and 59");
    }
    return Results.Ok("Calculated angle is: " + Processor.hourMinuteAngleSum(hour, minute));
})
.WithName("GetCalculateTimeAngle");

app.Run();
