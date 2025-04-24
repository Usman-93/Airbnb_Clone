using AirBnB_Clone.Contracts.Repositories;
using AirBnB_Clone.Data;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class ManageBookings : ComponentBase
{
    [Inject]
    public IAppRepository Repository { get; set; }
    
    [Parameter]
    public int HostId { get; set; }
    
    [Parameter]
    public int ListingId { get; set; }

    private List<Booking> AllActiveBookingsByHostAndListingId { get; set; }

    protected async override Task OnInitializedAsync()
    {
        AllActiveBookingsByHostAndListingId =  Repository.GetAllActiveBookingsByHostAndListingId(HostId, ListingId);
    }
}