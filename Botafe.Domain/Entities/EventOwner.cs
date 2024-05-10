using Botafe.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;

namespace Botafe.Domain.Entities
{
    public class EventOwner : AuditableEntity
    {
        public int Id { get; set; }
        public EventOwnerName EventOwnerName { get; set; }
        public List<Event> Events { get; set; } = new();

    }
}
