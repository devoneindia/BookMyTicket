namespace TicketBookingCore;

public interface ITicketBookingRepository
{
    public void Save(TicketBooking ticketBooking)
    {
        throw new NotImplementedException();
    }
}

public class TicketBooking
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}