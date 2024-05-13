using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Botafe.Persistance.Configurations
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.OwnsOne(p => p.ParticipantName).Property(p => p.FirstName).IsRequired();
            builder.OwnsOne(p => p.ParticipantName).Property(p => p.LastName).IsRequired();
            builder.OwnsOne(p => p.Email).Property(p => p.UserName).IsRequired();
            builder.OwnsOne(p => p.Email).Property(p => p.DomainName).IsRequired();
        }
    }
}
