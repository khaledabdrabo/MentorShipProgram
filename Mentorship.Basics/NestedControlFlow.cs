namespace Mentorship.Basics;

internal class NestedControlFlow
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