using AirBnB_Clone.Contracts.Repositories;
using AirBnB_Clone.Data;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class HostMode : ComponentBase
{
    [Inject]
    public IAppRepository Repository { get; set; }
    public Shared.Domain.Host Host { get; set; }
    
    [Parameter]
    public int HostId { get; set; }

    List<Listing> HostListings { get; set; }
    List<Booking> HostActiveBookings { get; set; }
    
    protected async override void OnInitialized()
    {
        // I am just selecting the first Host.
        // This will be changed when I look into Login and Authorization
        
            
        Host = Repository.GetHostById(HostId); 
        HostListings = Repository.GetListingsByHostId(HostId);
        HostActiveBookings = Repository.GetAllActiveBookingsByHostId(HostId); 
        
        
    }

}