using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;
using Botafe.Domain.ValueObjects;

namespace Botafe.Domain.Entities
{
    public class Participant : AuditableEntity
    {
        public int Id { get; set; }
        public ParticipantName ParticipantName { get; set; }
        public Email Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ParticipantAddressId { get; set; }
        public ParticipantAddress ParticipantAddress { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}
