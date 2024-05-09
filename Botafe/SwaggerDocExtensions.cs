using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Botafe
{
    public static class SwaggerDocExtensions
    {
        public static void SetSwaggerDoc (SwaggerGenOptions options)
        {
            options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
            {
                Title = "Botafe",
                Version = "v1",
                Description = "Aplikacja do zapisywania uczestników na eventy organizowane przez Botafe",
                Contact = new OpenApiContact()
                {
                    Name = "Łukasz"
                },

            });

            var filePath = Path.Combine(AppContext.BaseDirectory, "Botafe.xml");
            options.IncludeXmlComments(filePath);
        }
    }
}
