class Customer : User
{
    private List<Ticket> tickets;
    public Customer(string name, string email, string phoneNumber) : base(name, email, phoneNumber)
    {
        tickets = new List<Ticket>();
    }

    public override void viewBookingHistory()
    {
        base.viewBookingHistory();
    }

    public void addTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }
}