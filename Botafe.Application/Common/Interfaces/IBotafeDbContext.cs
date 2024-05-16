using Botafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Application.Common.Interfaces
{
    public interface IBotafeDbContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<EventOwner> EventOwners { get; set; }
        DbSet<Participant> Participants { get; set; }
        DbSet<Enrollment> Enrollments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
