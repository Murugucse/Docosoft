var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICounterService, CounterService>();

var app = builder.Build();

// Enable Swagger for all

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty; // Makes Swagger UI available at root "/"
    });

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();  // Enables /count route

// Optional: Add a root route to confirm deployment works
app.MapGet("/", () => "App is running!");

app.Run();
