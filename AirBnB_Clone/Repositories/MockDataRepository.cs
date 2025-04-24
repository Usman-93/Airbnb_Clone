using AirBnB_Clone.Contracts.Repositories;
using AirBnB_Clone.Data;
using AirBnB_Clone.Shared.Domain;

namespace AirBnB_Clone.Repositories;

public class MockDataRepository : IAppRepository
{
    private readonly MockDataContext _mockDataContext;

    public MockDataRepository(MockDataContext mockDataContext)
    {
        _mockDataContext = mockDataContext;
    }

    // Host
    public Shared.Domain.Host GetHostById(int hostId)
    {
        Shared.Domain.Host host = _mockDataContext.Hosts.Single(h => h.Id == 1);
        return host;
    }
    
    
    // Guest
    public Guest GetGuestById(int guestId)
    {
        Guest guest = _mockDataContext.Guests.Single(g => g.Id == guestId);
        return guest;
    }

    public void AddListing(Listing listing)
    {
        int maxListId = _mockDataContext.Listings.Max(Listing => Listing.Id);
        listing.Id = maxListId + 1;
        _mockDataContext.Listings.Add(listing);
    }

    public List<Listing> GetListingsByHostId(int hostId)
    {
        List<Listing> hostListings = _mockDataContext.Listings.Where(l => l.HostId == hostId).ToList();
        
        return hostListings;
    }

    public List<Booking> GetAllActiveBookingsByHostId(int hostId)
    {
        List<Booking> allActiveBookingsByHostId = _mockDataContext.Bookings.Where(b => b.HostId == hostId & b.Status == BookingStatus.Booked).ToList();
        return allActiveBookingsByHostId;
    }

    public List<Booking> GetAllActiveBookingsByHostAndListingId(int hostId, int listingId)
    {
        
        List<Booking>  allActiveBookingsByHostAndListingId = _mockDataContext.Bookings.Where(b => b.HostId == hostId 
                                                          & b.ListingId == listingId
                                                          & b.Status == BookingStatus.Booked
            ).ToList();
            
        return allActiveBookingsByHostAndListingId; 
    }
}