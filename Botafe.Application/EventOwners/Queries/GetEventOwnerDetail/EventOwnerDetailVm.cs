using AutoMapper;
using Botafe.Application.Common.Mappings;
using Botafe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Queries.GetEventOwnerDetail
{
    public class EventOwnerDetailVm : IMapFrom<EventOwner>
    {
        public string FullName { get; set; }
        public string LastEventName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EventOwner, EventOwnerDetailVm>()
                .ForMember(d => d.FullName, map => map.MapFrom(src => src.EventOwnerName.ToString()))
                .ForMember(d => d.LastEventName, map => map.MapFrom<LastEventNameResolver>());
        }

        private class LastEventNameResolver : IValueResolver<EventOwner, object, string>
        {
            public string Resolve(EventOwner source, object destination, string destMember, ResolutionContext context)
            {
                if(source.Events is not null && source.Events.Any())
                {
                    var lastEvent = source.Events.OrderByDescending(p => p.Created).FirstOrDefault();
                    return lastEvent.Name;
                }
                return string.Empty;
            }
        }
    }
}
