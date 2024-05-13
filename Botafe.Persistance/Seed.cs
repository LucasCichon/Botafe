using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botafe.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Botafe.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventOwner>(o =>
            {
                o.HasData(new EventOwner()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now
                });
                o.OwnsOne(n => n.EventOwnerName).HasData(new { FirstName = "Łukasz", LastName = "Knieć", EventOwnerId = 1 });
                o.OwnsOne(e => e.Email).HasData(new { UserName = "eventOwner1", DomainName = "gmail.com", EventOwnerId = 1 });
            });

            modelBuilder.Entity<ParticipantAddress>(a =>
            {
                a.HasData(new ParticipantAddress()
                {
                    Id = 1
                });
                a.OwnsOne(ad => ad.Address).HasData(new
                {
                    City = "Opole",
                    Country = "Polska",
                    Postcode = "45-403",
                    StreetName = "Ozimska",
                    StreetNumber = "34/5a",
                    Voivodeship = "Opolskie",
                    ParticipantAddressId = 1
                });
            });

            modelBuilder.Entity<Participant>(p =>
            {
                p.HasData(new Participant()
                {
                    Id = 1,
                    Created = DateTime.Now,
                    PhoneNumber = "111222333",
                    StatusId = 1,
                    ParticipantAddressId = 1
                });
                p.OwnsOne(e => e.Email).HasData(new { UserName = "participant1", DomainName = "gmail.com", ParticipantId = 1 });
                p.OwnsOne(n => n.ParticipantName).HasData(new { FirstName = "Lukasz", LastName = "Cichon", ParticipantId = 1 });
            });

            modelBuilder.Entity<Event>(e =>
            {
                e.HasData(new Event()
                {
                    Id = 1,
                    Name = "Ławka",
                    StartDate = new DateOnly(2024, 5, 25),
                    EndDate = new DateOnly(2024, 5, 31),
                    PlacesAvailable = 50,
                    EventOwnerId = 1
                });
            });
        }
    }
}
