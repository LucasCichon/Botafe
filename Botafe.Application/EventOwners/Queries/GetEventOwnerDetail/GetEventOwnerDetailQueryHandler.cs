using AutoMapper;
using Botafe.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Application.EventOwners.Queries.GetEventOwnerDetail
{
    public class GetEventOwnerDetailQueryHandler : IRequestHandler<GetEventOwnerDetailQuery, EventOwnerDetailVm>
    {
        private readonly IBotafeDbContext _botafeDbContext;
        private IMapper _mapper;

        public GetEventOwnerDetailQueryHandler(IBotafeDbContext botafeDbContext, IMapper mapper)
        {
            _botafeDbContext = botafeDbContext;
            _mapper = mapper;
        }
        public async Task<EventOwnerDetailVm> Handle(GetEventOwnerDetailQuery request, CancellationToken cancellationToken)
        {
            var eventOwner = await _botafeDbContext.EventOwners.Include(p => p.Events).Where(e => e.Id == request.EventOwnerId)
                .FirstOrDefaultAsync(cancellationToken);

            var eventOwnerVm = _mapper.Map<EventOwnerDetailVm>(eventOwner);

            return eventOwnerVm;
        }
    }
}
