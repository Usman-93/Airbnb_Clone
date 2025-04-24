namespace AirBnB_Clone.Shared.Domain;

public class Guest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string Email { get; set; }
    
}