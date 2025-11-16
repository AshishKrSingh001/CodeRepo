class Reservation
{
    private int TicketId;
    Reservation(int Id)
    {
        this.TicketId=Id;
    }
    public void ShowTicket()
    {
        System.out.println("Ticket id: "+TicketId);
    }
    public static void main(String[] args) 
    {
        Reservation res = new Reservation(13089);
        res.ShowTicket();

    }
}