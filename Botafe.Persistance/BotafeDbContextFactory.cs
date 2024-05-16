using Botafe.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Persistance
{
    public class BotafeDbContextFactory : DesignTimeDbContextFactoryBase<BotafeDbContext>
    {
        private readonly IDateTime _dateTime;

        public BotafeDbContextFactory(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }
        protected override BotafeDbContext CreateNewInstance(DbContextOptions<BotafeDbContext> options)
        {
            return new BotafeDbContext(options, _dateTime);
        }
    }
}
