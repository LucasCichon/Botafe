using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Commands.CreateEventOwner
{
    public class CreateEventOwnerCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }

    }
}
