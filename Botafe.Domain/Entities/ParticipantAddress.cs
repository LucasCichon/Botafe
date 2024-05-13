using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;
using Botafe.Domain.ValueObjects;

namespace Botafe.Domain.Entities
{
    public class ParticipantAddress : AuditableEntity
    {
        public int Id { get; set; }
        public Address Address { get; set; }
    }
}
