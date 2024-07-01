using Application.Interfaces.GNCInterfaces;
using Application.Interfaces.LocalidadInterfaces;
using Application.Interfaces.RangoEtarioInterfaces;
using Application.Interfaces.VehiculoInterfaces;
using Application.Interfaces.VersionVehiculoInterfaces;
using Application.UseCase.Vehiculos;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Queries;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces.AnioVehiculosInterfaces;
using Application.UseCase.Localidades;
using Application.UseCase.GNCs;
using Application.UseCase.RangosEtarios;
using Application.UseCase.AnioVehiculos;
using Application.Interfaces.ObjetoInformacionParametrizadaInterfaces;
using Application.Util;
using Application.UseCase.VersionVehiculos;
using Application.Interfaces.MarcaInterfaces;
using Application.UseCase.Marca;
using Application.Interfaces.ModeloInterfaces;
using Application.UseCase.Modelo;
using Application.Interfaces.Http;
using Application.UseCase.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<IObtenerInformacionParametrizada, ObtenerInformacionParametrizada>();

builder.Services.AddScoped<IVehiculosCommand, VehiculosCommand>();
builder.Services.AddScoped<IVehiculoService, VehiculoService>();

builder.Services.AddScoped<IGNCQuery, GNCQuery>();
builder.Services.AddScoped<IGNCService, GNCService>();

builder.Services.AddScoped<ILocalidadService, LocalidadService>();
builder.Services.AddScoped<ILocalidadQuery, LocalidadQuery>();

builder.Services.AddScoped<IRangoEtarioQuery, RangoEtarioQuery>();
builder.Services.AddScoped<IRangoEtarioService, RangoEtarioService>();

builder.Services.AddScoped<IVersionVehiculoQuery, VersionVehiculoQuery>();
builder.Services.AddScoped<IVersionVehiculoService, VersionVehiculoService>();

builder.Services.AddScoped<IAnioVehiculoQuery, AnioVehiculoQuery>();
builder.Services.AddScoped<IAnioVehiculoService, AnioVehiculoService>();

builder.Services.AddScoped<IMarcaService, MarcaService>();
builder.Services.AddScoped<IMarcaQuery, MarcaQuery>();

builder.Services.AddScoped<IModeloService, ModeloService>();
builder.Services.AddScoped<IModeloQuery, ModeloQuery>();

builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<IHttpService, HttpService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolitic", app => {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("NewPolitic");

app.UseAuthorization();

app.MapControllers();

app.Run();
