using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;

namespace Botafe.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int PlacesAvailable { get; set; }

        // jeżeli nie będzie '?', to usuwając Ownera, automatycznie wszyskie jego Eventy zostaną usunięte...
        public int? EventOwnerId { get; set; }
        public EventOwner EventOwner { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}
