using Microsoft.EntityFrameworkCore;
using TechStore.Api.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
                       ?? "Data Source=techstore.db";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=techstore.db"));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy("Producao", policy => 
    {
        policy.WithOrigins(
                "http://localhost:5500", 
                "http://127.0.0.1:5500",
                "https://meu-site.com"      // Caso futuramente colocar uma URL
              )
              .WithMethods("GET", "POST", "PUT", "DELETE")
              .WithHeaders("Content-Type", "Authorization");
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TechStore API v1");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseCors("Producao");
app.MapControllers();

app.Run();