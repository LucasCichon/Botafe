using Botafe.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Application.EventOwners.Queries.GetDirectorDetail
{
    public class GetEventOwnerDetailQueryHandler : IRequestHandler<GetEventOwnerDetailQuery, EventOwnerDetailVm>
    {
        private readonly IBotafeDbContext _botafeDbContext;

        public GetEventOwnerDetailQueryHandler(IBotafeDbContext botafeDbContext)
        {
            _botafeDbContext = botafeDbContext;
        }
        public async Task<EventOwnerDetailVm> Handle(GetEventOwnerDetailQuery request, CancellationToken cancellationToken)
        {
            var eventOwner = await _botafeDbContext.EventOwners.Where(e => e.Id == request.EventOwnerId)
                .FirstOrDefaultAsync(cancellationToken);

            var eventOwnerVm = new EventOwnerDetailVm()
            {
                FullName = eventOwner.EventOwnerName.ToString(),
                LastEventName = eventOwner.Events.OrderByDescending(p => p.StartDate).FirstOrDefault()?.Name
            };

            return eventOwnerVm;
        }
    }
}
