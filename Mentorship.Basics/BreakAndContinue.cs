namespace Mentorship.Basics;

internal class BreakAndContinue
{
    public static void GameOptions()
    {
        bool condition = true;
        while(condition)
        {
            displayMenu();
            string userChoice = ReadLine();
            switch(userChoice.ToLower())
            {
                case "quit":
                    WriteLine("Exiting the game");
                    condition = false;
                    break;
                case "skip":
                    WriteLine("Skipping to the next level");
                    break;
                default:
                    WriteLine("Invalid choice. Please try again");
                    break;
            }
        }
    }
    private static void displayMenu()
    {
        WriteLine("choose one of the choices !");
        WriteLine("Quit\nskip\n");
    }
}