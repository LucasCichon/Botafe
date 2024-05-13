using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Common;
using Botafe.Domain.Exceptions;

namespace Botafe.Domain.Entities
{
    public class Email : ValueObject
    {
        public string UserName { get; set; }
        public string DomainName { get; set; }

        public static Email For(string email)
        {
            var result = new Email();

            try
            {
                var index = email.IndexOf("@", StringComparison.Ordinal);
                result.UserName = email.Substring(0, index);
                result.DomainName = email.Substring(index + 1);
            }
            catch (Exception e)
            {
                throw new EmailException(email, e);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{UserName}@{DomainName}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UserName;
            yield return DomainName;
        }
    }
}
