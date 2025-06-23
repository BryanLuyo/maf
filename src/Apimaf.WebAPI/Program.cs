using Apimaf.Application.Services;
using Apimaf.Domain.Interfaces;
using Apimaf.Infrastructure.Data;
using Apimaf.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Apimaf.WebAPI;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
Env.Load();


// TODO: Configurar cadena de conexión (valor por defecto en appsettings)
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ??
                       builder.Configuration.GetConnectionString("Default") ??
                       string.Empty;

// TODO: Registrar DbContext y servicios
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<ConcesionarioService>();
builder.Services.AddScoped<SucursalService>();
builder.Services.AddScoped<MarcaService>();
builder.Services.AddScoped<ModeloService>();

builder.Services.AddScoped<IConcesionarioRepository, ConcesionarioRepository>();
builder.Services.AddScoped<ISucursalRepository, SucursalRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IModeloRepository, ModeloRepository>();

// TODO: Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware de manejo de errores
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

// Habilitar los controladores
app.MapControllers();
app.Run();

public partial class Program { }