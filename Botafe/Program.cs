
using Botafe.Infrastructure;
using Botafe.Persistance;

namespace Botafe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
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

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHealthChecks("/hc");

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
