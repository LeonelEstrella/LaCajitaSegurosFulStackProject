using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.UserCase;
using Infraestructure;
using Infraestructure.Commands;
using Infraestructure.Querys;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace PolizasYSiniestros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddCors(p => p.AddPolicy("PolicyCors", build
    => {
        build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();

    }));

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Logging.AddLog4Net();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                //options.EnableAnnotations();
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Microservicio - Polizas y Siniestros",
                    Description = "TP - Integrador - La Cajita Seguros",
                    Contact = new OpenApiContact
                    {
                        Name = "Maximiliano Ortiz",
                    }
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });


            //Config Automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Inyection ApplicationDbContext
            var connectionString = builder.Configuration["ConnectionString"];
            builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));

            //Custom Inyection Dependency
            builder.Services.AddTransient<IPolizaService, PolizaServiceImpl>();
            builder.Services.AddTransient<IGenericRepository, GenericRepositoryImpl>();
            builder.Services.AddTransient<IValidacionesRepository, ValidacionesRepositoryImpl>();
            builder.Services.AddTransient<ISiniestroService, SiniestroServiceImpl>();
            builder.Services.AddTransient<IPolizaRepository, PolizaRepositoryImpl>();
            builder.Services.AddTransient<IVersionRepository, VersionRepositoryImpl>();
            builder.Services.AddTransient<IProviciaRepository, ProvinciaRepositoryImpl>();
            builder.Services.AddTransient<ILocalidadRepository, LocalidaRepositoryImpl>();
            builder.Services.AddTransient<IFormateoUbicacionService, FormateoUbicacionService>();
            builder.Services.AddTransient<IFormateoVehiculoVersionService, FormateoVehiculoVersionServiceImpl>();
            builder.Services.AddScoped<HttpClient, HttpClient>();
            builder.Services.AddTransient<IHttpServer, HttpServiceImpl>();


            var app = builder.Build();

            


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("PolicyCors");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
