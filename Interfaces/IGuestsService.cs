using System;
using System.Collections.Generic;
using System.ServiceModel;
using GuestsShared.Models;

namespace GuestsShared.Interfaces
{
    [ServiceContract]
    public interface IGuestsService
    {
        [OperationContract]
        List<HouseholdModel> GetAllHouseholds();

        [OperationContract]
        HouseholdModel GetHouseholdById(Guid householdId);

        [OperationContract]
        List<GuestModel> GetAllGuests();

        [OperationContract]
        GuestModel GetGuestById(Guid guestId);

        [OperationContract]
        List<GuestModel> GetGuestsInHousehold(Guid householdId);

        [OperationContract]
        bool UpdateSeatByGuestId(Guid id, int seatNumber);

        [OperationContract]
        void AddNewGuest(GuestModel newGuestModel);
    }
}