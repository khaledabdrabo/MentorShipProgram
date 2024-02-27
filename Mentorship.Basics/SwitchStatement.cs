namespace Mentorship.Basics;

public class SwitchStatement
{
    public static void MenuOptionExecution(int userChoice)
    {
        switch(userChoice)
        { 
            case 1:
                Console.WriteLine("Executing action for choice 1");
                break;
            case 2:
                Console.WriteLine("Executing action for choice 2");
                break;
            // Add more cases as needed
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}