using System.Reflection;
using Botafe.Application.Common.Interfaces;
using Botafe.Domain.Common;
using Botafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Persistance
{
    public class BotafeDbContext : DbContext, IBotafeDbContext
    {
        private readonly IDateTime _dateTime;

        public BotafeDbContext(DbContextOptions<BotafeDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventOwner> EventOwners { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<ParticipantAddress> ParticipantsAddress { get; set; }
        public DbSet<EventOwnerAddress> EventOwnerAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified= _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
