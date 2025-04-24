using AirBnB_Clone.Services;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class Home : ComponentBase
{
    public Shared.Domain.Host Host { get; set; }
    public Guest Guest { get; set; }
    
    protected override void OnInitialized()
    {
        // I am just selecting the first Host.
        // This will be changed when I look into Login and Authorization
        
        Host = MockDataService.Hosts.Single(h => h.Id == 1);


        Guest = MockDataService.Guests.Single(h => h.Id == 1);
 
        
    }
}