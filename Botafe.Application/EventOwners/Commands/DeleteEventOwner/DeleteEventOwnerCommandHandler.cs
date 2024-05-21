using Botafe.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Commands.DeleteEventOwner
{
    public class DeleteEventOwnerCommandHandler : IRequestHandler<DeleteEventOwnerCommand, Unit>
    {
        private readonly IBotafeDbContext _context;

        public DeleteEventOwnerCommandHandler(IBotafeDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteEventOwnerCommand request, CancellationToken cancellationToken)
        {
            var eventOwner = await _context.EventOwners.Where(p => p.Id == request.EventOwnerId).FirstOrDefaultAsync(cancellationToken);

            _context.EventOwners.Remove(eventOwner);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
