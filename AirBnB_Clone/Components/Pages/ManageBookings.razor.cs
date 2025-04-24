using AirBnB_Clone.Services;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class ManageBookings : ComponentBase
{
    [Parameter]
    public int HostId { get; set; }
    
    [Parameter]
    public int ListingId { get; set; }

    private List<Booking> ActiveBookings { get; set; }

    protected async override Task OnInitializedAsync()
    {
        ActiveBookings = MockDataService.Bookings.Where(x => x.HostId == HostId 
                                                              & x.ListingId == ListingId
                                                              & x.Status == BookingStatus.Booked
        ).ToList();
    }
}