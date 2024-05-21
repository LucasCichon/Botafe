using MediatR;

namespace Botafe.Application.EventOwners.Queries.GetEventOwnerDetail
{
    public class GetEventOwnerDetailQuery : IRequest<EventOwnerDetailVm>
    {
        public int EventOwnerId { get; set; }

    }
}
