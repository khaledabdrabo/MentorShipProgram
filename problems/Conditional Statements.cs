using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class Conditional_Statements
    {
        public static void SeatAvailabilityCheck(bool seatAvailability)
        {
            if (seatAvailability)
            {
                Console.WriteLine("Seat is available for booking");
            }
            else
            {
                Console.WriteLine("Seat is not available");
            }

        }

    }
}
