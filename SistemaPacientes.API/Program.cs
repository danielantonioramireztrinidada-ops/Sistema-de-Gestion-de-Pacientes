using Microsoft.EntityFrameworkCore;
using SistemaPacientes.Infrastructure.Data;
using SistemaPacientes.Application.Interfaces;
using SistemaPacientes.Application.Services;
using SistemaPacientes.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Configurar controladores
builder.Services.AddControllers();
builder.Services.AddScoped<IPacienteService, PacienteService>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();

// Configurar conexion con SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// Configurar OpenAPI
builder.Services.AddOpenApi();
builder.Services.AddCors(options =>
{
    options.AddPolicy("BlazorPolicy", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configurar OpenAPI en desarrollo
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("BlazorPolicy");

// Activar controladores
app.MapControllers();

app.Run();