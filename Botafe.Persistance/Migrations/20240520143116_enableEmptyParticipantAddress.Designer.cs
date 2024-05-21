﻿// <auto-generated />
using System;
using Botafe.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    [DbContext(typeof(BotafeDbContext))]
    [Migration("20240520143116_enableEmptyParticipantAddress")]
    partial class enableEmptyParticipantAddress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Botafe.Domain.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int?>("EventOwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlacesAvailable")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventOwnerId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateOnly(2024, 5, 31),
                            EventOwnerId = 1,
                            Name = "Ławka",
                            PlacesAvailable = 50,
                            StartDate = new DateOnly(2024, 5, 25),
                            StatusId = 0
                        });
                });

            modelBuilder.Entity("Botafe.Domain.Entities.EventOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventOwnerAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventOwnerAddressId");

                    b.ToTable("EventOwners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 5, 20, 16, 31, 16, 218, DateTimeKind.Local).AddTicks(4075),
                            EventOwnerAddressId = 1,
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("Botafe.Domain.Entities.EventOwnerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EventOwnerAddresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 0
                        });
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParticipantAddressId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantAddressId");

                    b.ToTable("Participants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 5, 20, 16, 31, 16, 218, DateTimeKind.Local).AddTicks(5048),
                            ParticipantAddressId = 1,
                            PhoneNumber = "111222333",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("Botafe.Domain.Entities.ParticipantAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParticipantsAddress");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 0
                        });
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("Botafe.Domain.Entities.Event", "Event")
                        .WithMany("Enrollments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Botafe.Domain.Entities.Participant", "Participant")
                        .WithMany("Enrollments")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Event", b =>
                {
                    b.HasOne("Botafe.Domain.Entities.EventOwner", "EventOwner")
                        .WithMany("Events")
                        .HasForeignKey("EventOwnerId");

                    b.Navigation("EventOwner");
                });

            modelBuilder.Entity("Botafe.Domain.Entities.EventOwner", b =>
                {
                    b.HasOne("Botafe.Domain.Entities.EventOwnerAddress", "EventOwnerAddress")
                        .WithMany()
                        .HasForeignKey("EventOwnerAddressId");

                    b.OwnsOne("Botafe.Domain.Entities.Email", "Email", b1 =>
                        {
                            b1.Property<int>("EventOwnerId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EventOwnerId");

                            b1.ToTable("EventOwners");

                            b1.WithOwner()
                                .HasForeignKey("EventOwnerId");

                            b1.HasData(
                                new
                                {
                                    EventOwnerId = 1,
                                    DomainName = "gmail.com",
                                    UserName = "eventOwner1"
                                });
                        });

                    b.OwnsOne("Botafe.Domain.ValueObjects.EventOwnerName", "EventOwnerName", b1 =>
                        {
                            b1.Property<int>("EventOwnerId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EventOwnerId");

                            b1.ToTable("EventOwners");

                            b1.WithOwner()
                                .HasForeignKey("EventOwnerId");

                            b1.HasData(
                                new
                                {
                                    EventOwnerId = 1,
                                    FirstName = "Łukasz",
                                    LastName = "Knieć"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("EventOwnerAddress");

                    b.Navigation("EventOwnerName")
                        .IsRequired();
                });

            modelBuilder.Entity("Botafe.Domain.Entities.EventOwnerAddress", b =>
                {
                    b.OwnsOne("Botafe.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<int>("EventOwnerAddressId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Postcode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Voivodeship")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EventOwnerAddressId");

                            b1.ToTable("EventOwnerAddresses");

                            b1.WithOwner()
                                .HasForeignKey("EventOwnerAddressId");

                            b1.HasData(
                                new
                                {
                                    EventOwnerAddressId = 1,
                                    City = "Opole",
                                    Country = "Polska",
                                    Postcode = "45-403",
                                    StreetName = "Ozimska",
                                    StreetNumber = "34/5a",
                                    Voivodeship = "Opolskie"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Participant", b =>
                {
                    b.HasOne("Botafe.Domain.Entities.ParticipantAddress", "ParticipantAddress")
                        .WithMany()
                        .HasForeignKey("ParticipantAddressId");

                    b.OwnsOne("Botafe.Domain.Entities.Email", "Email", b1 =>
                        {
                            b1.Property<int>("ParticipantId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ParticipantId");

                            b1.ToTable("Participants");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantId");

                            b1.HasData(
                                new
                                {
                                    ParticipantId = 1,
                                    DomainName = "gmail.com",
                                    UserName = "participant1"
                                });
                        });

                    b.OwnsOne("Botafe.Domain.ValueObjects.ParticipantName", "ParticipantName", b1 =>
                        {
                            b1.Property<int>("ParticipantId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ParticipantId");

                            b1.ToTable("Participants");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantId");

                            b1.HasData(
                                new
                                {
                                    ParticipantId = 1,
                                    FirstName = "Lukasz",
                                    LastName = "Cichon"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("ParticipantAddress");

                    b.Navigation("ParticipantName")
                        .IsRequired();
                });

            modelBuilder.Entity("Botafe.Domain.Entities.ParticipantAddress", b =>
                {
                    b.OwnsOne("Botafe.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<int>("ParticipantAddressId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Postcode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Voivodeship")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ParticipantAddressId");

                            b1.ToTable("ParticipantsAddress");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantAddressId");

                            b1.HasData(
                                new
                                {
                                    ParticipantAddressId = 1,
                                    City = "Opole",
                                    Country = "Polska",
                                    Postcode = "45-403",
                                    StreetName = "Ozimska",
                                    StreetNumber = "34/5a",
                                    Voivodeship = "Opolskie"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Event", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Botafe.Domain.Entities.EventOwner", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Botafe.Domain.Entities.Participant", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
