
using Botafe.Application;
using Botafe.Infrastructure;
using Botafe.Persistance;
using Serilog;

namespace Botafe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
         
                var builder = WebApplication.CreateBuilder(args);
                //Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();

                builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

                builder.Services.AddApplication();
                builder.Services.AddPersistance(builder.Configuration);
                builder.Services.AddInfrastructure(builder.Configuration);
                builder.Services.AddCors(options => options.AddPolicy(name: "MyAllowSpecificOrigins",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:44376", "https://localhost:7267");
                    }));

                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen(c => SwaggerDocExtensions.SetSwaggerDoc(c));
                builder.Services.AddHealthChecks();

                var app = builder.Build();
                Log.Information("Application is starting up");

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHealthChecks("/hc");

                app.UseHttpsRedirection();

                app.UseSerilogRequestLogging();

                app.UseCors();

                app.UseAuthorization();

                app.MapControllers();

                app.Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Could not start up application");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
