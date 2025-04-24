using AirBnB_Clone.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace AirBnB_Clone.Components;

public partial class ListingCard : ComponentBase
{
    [Parameter]
    public Listing Listing { get; set; } 
    
    [Parameter]
    public int HostId { get; set; }
}