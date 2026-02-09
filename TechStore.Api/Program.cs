using Microsoft.EntityFrameworkCore;
using TechStore.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=techstore.db"));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => {
    options.AddPolicy("PermitirTudo",
        policy => policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("PermitirTudo");
app.MapControllers();

app.Run();