using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;

namespace Botafe.Domain.Entities
{
    public class Enrollment : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public Participant Participant { get; set; }
        public int ParticipantId { get; set; }
    }
}
