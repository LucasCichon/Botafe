using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;

namespace Botafe.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Voivodeship { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }

        public override string ToString()
        {
            return $"ul. {StreetName} {StreetNumber}, {Postcode} {City}, {Country}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
            yield return Postcode;
            yield return Voivodeship;
            yield return StreetName;
            yield return StreetNumber;
        }
    }
}
