using Microsoft.EntityFrameworkCore;

namespace Botafe.Persistance
{
    public class BotafeDbContextFactory : DesignTimeDbContextFactoryBase<BotafeDbContext>
    {
        protected override BotafeDbContext CreateNewInstance(DbContextOptions<BotafeDbContext> options)
        {
            return new BotafeDbContext(options);
        }
    }
}
