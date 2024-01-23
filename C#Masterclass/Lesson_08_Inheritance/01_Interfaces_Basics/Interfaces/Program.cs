Ticket ticket1 = new Ticket(10);
Ticket ticket2 = new Ticket(10);

Console.WriteLine(ticket1.Equals(ticket2));

Console.ReadLine();

public class Ticket : IEquatable<Ticket>
{
    // property to store the duration of the ticket in hours

    public int DurationInHours { get; set; }

    // simple constructor

    public Ticket(int durationInHours)
    {
        DurationInHours = durationInHours;
    }

    public bool Equals(Ticket ticket)
    {
        // we compare to instances aand if they both have the same DurationInHours it will return true
        return this.DurationInHours == ticket.DurationInHours;
    }
}