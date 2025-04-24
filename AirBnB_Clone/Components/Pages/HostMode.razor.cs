using AirBnB_Clone.Services;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class HostMode : ComponentBase
{
    public Shared.Domain.Host Host { get; set; }
    
    [Parameter]
    public int HostId { get; set; }

    List<Listing> HostListings { get; set; }
    List<Booking> HostActiveBookings { get; set; }
    
    protected async override void OnInitialized()
    {
        // I am just selecting the first Host.
        // This will be changed when I look into Login and Authorization
        Host = MockDataService.Hosts.Single(h => h.Id == HostId);
        
        HostListings = MockDataService.Listings.Where(l => l.HostId == HostId).ToList();
        HostActiveBookings = MockDataService.Bookings.Where(b => b.HostId == HostId & b.Status == BookingStatus.Booked).ToList();
        
        
    }

}