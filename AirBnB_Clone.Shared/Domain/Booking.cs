namespace AirBnB_Clone.Shared.Domain;

public class Booking
{
    public int Id { get; set; }
    public int GuestId { get; set; }
    public int HostId { get; set; }
    public int ListingId { get; set; }
    public BookingStatus Status { get; set; }
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }
}