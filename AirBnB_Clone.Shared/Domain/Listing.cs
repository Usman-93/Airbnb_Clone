namespace AirBnB_Clone.Shared.Domain;

public class Listing
{
    public int Id { get; set; }
    public int HostId { get; set; }
    public string ListingName { get; set; }
    public int Price { get; set; }
    
}