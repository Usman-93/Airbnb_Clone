using AirBnB_Clone.Contracts.Repositories;
using AirBnB_Clone.Data;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    public IAppRepository Repository { get; set; }
    public Shared.Domain.Host Host { get; set; }
    public Guest Guest { get; set; }
    
    protected override void OnInitialized()
    {
        // I am just selecting the first Host.
        // This will be changed when I look into Login and Authorization
        
        Host = Repository.GetHostById(1);

        Guest = Repository.GetGuestById(1);
 
        
    }
}