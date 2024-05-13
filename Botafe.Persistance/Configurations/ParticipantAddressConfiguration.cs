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
    public class ParticipantAddressConfiguration : IEntityTypeConfiguration<ParticipantAddress>
    {
        public void Configure(EntityTypeBuilder<ParticipantAddress> builder)
        {
            builder.OwnsOne(p => p.Address);
        }
    }
}
