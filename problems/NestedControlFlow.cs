using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class NestedControlFlow
    {
        public static void SimulateTrafficLight(string state)
        {
            switch (state)
            {
                case "red":
                    Console.WriteLine("Stop");
                    break;
                case "yellow":
                    Console.WriteLine("Proceed with caution");
                    break;
                case "green":
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Invalid traffic light state");
                    break;
            }
        }
    }
}
