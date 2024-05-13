using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Botafe.Persistance.Configurations
{
    public class EventOwnerConfiguration : IEntityTypeConfiguration<EventOwner>
    {
        public void Configure(EntityTypeBuilder<EventOwner> builder)
        {
            builder.OwnsOne(e => e.EventOwnerName).Property(p => p.FirstName).IsRequired();
            builder.OwnsOne(e => e.EventOwnerName).Property(p => p.LastName).IsRequired();
            builder.OwnsOne(e => e.Email).Property(p => p.UserName).IsRequired();
            builder.OwnsOne(e => e.Email).Property(p => p.DomainName).IsRequired();
        }
    }
}
