var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options =>
{
    options.ListenAnyIP(80); // Listen for requests on port 80 from any IP
});

builder.Services.AddControllers()
    .AddApplicationPart(typeof(TuneIQ.API.Controllers.HealthController).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comment out HTTPS redirection for now to simplify testing
// app.UseHttpsRedirection();

// Use CORS
app.UseCors();

app.UseRouting();

app.UseAuthorization();

app.UseWebSockets(new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromSeconds(120),
});

app.MapControllers();

app.MapFallback(context =>
{
    context.Response.StatusCode = 200;
    return context.Response.WriteAsync($"Received request for {context.Request.Path}");
});

// Add this line to log the URLs the app is listening on
app.Lifetime.ApplicationStarted.Register(() =>
{
    var urls = app.Urls;
    Console.WriteLine($"Application listening on: {string.Join(", ", urls)}");
});

app.Run();
