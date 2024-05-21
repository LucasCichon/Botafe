using Botafe.Application.Common.Interfaces;
using Botafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Commands.CreateEventOwner
{
    public class CreateEventOwnerCommandHandler : IRequestHandler<CreateEventOwnerCommand, int>
    {
        private readonly IBotafeDbContext _context;

        public CreateEventOwnerCommandHandler(IBotafeDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateEventOwnerCommand request, CancellationToken cancellationToken)
        {
            EventOwner owner = new()
            {
                EventOwnerName = new Domain.ValueObjects.EventOwnerName() { FirstName = request.FirstName, LastName = request.LastName },
                Email = Email.For(request.Email)
            };

            _context.EventOwners.Add(owner);

            EventOwnerAddress address = new()
            {
                Address = new Domain.ValueObjects.Address()
                {
                    City = request.Address.City,
                    Country = request.Address.Country,
                    Postcode = request.Address.Postcode,
                    StreetName = request.Address.StreetName,
                    StreetNumber = request.Address.StreetNumber,
                    Voivodeship = request.Address.Voivodeship
                },
                Id = owner.Id
            };

            _context.EventOwnerAddresses.Add(address);

            await _context.SaveChangesAsync(cancellationToken);

            return owner.Id;
        }
    }
}
