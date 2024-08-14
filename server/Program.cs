using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });

builder.Services.AddCors(coreOptions =>
    coreOptions.AddPolicy("All", options =>
    {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.WithOrigins("http://127.0.0.1:6002/");
        options.AllowCredentials();
        options.SetIsOriginAllowed(_ => true);
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseCors("All");

app.MapControllers();

app.Run();

