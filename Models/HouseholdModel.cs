using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GuestsShared.Models
{
    [DataContract]
    public class HouseholdModel
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public virtual ICollection<GuestModel> GuestsInHousehold { get; set; }
    }
}