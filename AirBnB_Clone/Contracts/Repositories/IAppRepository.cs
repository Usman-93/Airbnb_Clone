using AirBnB_Clone.Shared.Domain;

namespace AirBnB_Clone.Contracts.Repositories;

public interface IAppRepository
{
    // Host
    Shared.Domain.Host GetHostById(int hostId);

    // Guest
    Guest GetGuestById(int guestId);
    
    // Listing
    void AddListing(Listing listing);
    List<Listing> GetListingsByHostId(int hostId); 
   
    // Booking
    List<Booking> GetAllActiveBookingsByHostId(int hostId);
    List<Booking> GetAllActiveBookingsByHostAndListingId(int hostId, int listingId);
    
    
}