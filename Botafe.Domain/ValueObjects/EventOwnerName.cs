using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;

namespace Botafe.Domain.ValueObjects
{
    public class EventOwnerName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
