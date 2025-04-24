using AirBnB_Clone.Contracts.Repositories;
using AirBnB_Clone.Data;
using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components.Pages;

public partial class AddListing : ComponentBase
{
    [Inject]
    public IAppRepository Repository { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    
    [SupplyParameterFromForm]
    public Listing NewListing { get; set; }
    
    [Parameter]
    public int HostId { get; set; }

    protected bool Saved { get; set; }

    protected override void OnInitialized()
    {
        NewListing ??= new Listing();
        Saved = false;
    }

    private void OnSubmit()
    {
        NewListing.HostId = HostId;
        Repository.AddListing(NewListing);
        Saved = true;
        
    }
    
    protected void NavigateToHostMode()
    {
        NavigationManager.NavigateTo($"/HostMode/{HostId}");
    }


}