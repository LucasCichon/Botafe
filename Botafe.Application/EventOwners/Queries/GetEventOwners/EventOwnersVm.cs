using Botafe.Domain.Entities;

namespace Botafe.Application.EventOwners.Queries.GetEventOwners
{
    public class EventOwnersVm
    {
        private ICollection<EventOwnerDto> EventOwners { get; set; }
    }
}
