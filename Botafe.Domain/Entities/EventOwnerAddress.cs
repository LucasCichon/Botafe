using Botafe.Domain.Common;
using Botafe.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Domain.Entities
{
    public class EventOwnerAddress : AuditableEntity
    {
        public int Id { get; set; }
        public Address Address { get; set; }
    }
}
