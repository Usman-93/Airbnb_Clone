using AirBnB_Clone.Shared.Domain;

namespace AirBnB_Clone.Data;

public class MockDataContext
{
    public List<Shared.Domain.Host> Hosts { get; private set; } 
    public List<Guest> Guests {get; private set; }
    public List<Listing> Listings {get; private set; }
    public List<Booking> Bookings {get; private set; }
    

    // public static MockDataContext Instance { get; } = new MockDataContext();

    public MockDataContext()
    {
        // I think the order in which you load them is important. So just think about the order in which you are running them
        Hosts = InitializeHosts();
        Guests = InitializeGuests();
        Listings = InitializeListings();
        Bookings = InitializeBookings();
        
    }

    private static List<Shared.Domain.Host> InitializeHosts()
    {
        List<Shared.Domain.Host> hosts = new List<Shared.Domain.Host>()
        {
            new () 
                {
                    Id = 1, 
                    FirstName = "Usman", 
                    LastName = "Rahat", 
                    Email = "engr.usmanrahat93@gmail.com",
                    
                },
            new () 
            {
                Id = 2, 
                FirstName = "Usman2", 
                LastName = "Rahat2", 
                Email = "engr.usmanrahat93@gmail.com2",
            }
            
        };
        return hosts;
        
    }
    private static List<Guest> InitializeGuests()
    {
        List<Guest> guests = new List<Guest>()
        {
            new()
            {
                Id = 1,
                FirstName = "Guest-firstName",
                LastName = "Guest-lastName",
                Email = "guest-email@gmail.com"
            }
        };

        return guests;
    }
    private static List<Listing> InitializeListings()
    {
        List<Listing> listings = new List<Listing>()
        {
            new ()
            {
                Id = 1,
                ListingName = "The Hancock Homestead - Ensuite Room",
                HostId = 1,
                Price = 100
            },
            new ()
            {
                Id = 2,
                ListingName = "The Hancock Homestead - Backyard II",
                HostId = 1,
                Price = 250
            },
            new ()
            {
                Id = 3,
                ListingName = "Other Property",
                HostId = 2,
                Price = 120
            }
            
        };
        
        return listings;
    }
    private static List<Booking> InitializeBookings()
    {
        List<Booking> bookings = new List<Booking>()
        {
            new()
            {
                Id = 1,
                HostId = 1,
                GuestId = 1,
                ListingId = 1,
                Status = BookingStatus.Booked,
                FromDate = default,
                ToDate = default

            },
            new()
            {
                Id = 2,
                HostId = 1,
                GuestId = 2,
                ListingId = 1,
                Status = BookingStatus.Booked,
                FromDate = default,
                ToDate = default

            }
        };
        
        return bookings;
    }
}

