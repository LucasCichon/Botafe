using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Botafe.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BotafeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BotafeDatabase")));

            services.AddScoped<IBotafeDbContext, BotafeDbContext>();
            return services;
        }
    }
}
