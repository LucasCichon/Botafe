using MediatR;

namespace Botafe.Application.EventOwners.Queries.GetDirectorDetail
{
    public class GetEventOwnerDetailQuery : IRequest<EventOwnerDetailVm>
    {
        public int EventOwnerId { get; set; }

    }
}
