using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Commands.DeleteEventOwner
{
    public class DeleteEventOwnerCommand : IRequest<Unit>
    {
        public int EventOwnerId { get; set; }
    }
}
