using System;
using System.Runtime.Serialization;
using GuestsShared.Enums;

namespace GuestsShared.Models
{
    public class GuestModel
    {
        [DataMember] public Guid Id { get; set; }
        [DataMember] public Guid HouseholdId { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string LastName { get; set; }
        [DataMember] public int? SeatNumber { get; set; }
        [DataMember] public int RsvpStatusId { get; set; }
        [DataMember] public string DietaryRequirements { get; set; }
        [DataMember] public string SongRequest { get; set; }
        [DataMember] public bool IsChild { get; set; }
        [DataMember] public HotelRequirement HotelRequirement { get; set; }
        [DataMember] public bool NeedsTransport { get; set; }
    }
}