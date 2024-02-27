namespace Mentorship.Basics;

internal class ConditionalStatements
{
    public static void SeatAvailabilityCheck(bool seatAvailability)
    {
        if (seatAvailability is true)
            Console.WriteLine("Seat is available for booking");
        else
            Console.WriteLine("Seat is not available");
    }
}