using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class BreakAndContinue
    {
        public static void GameOptions()
        {
            while (true)
            {
                DisplayMenu();
                string userChoice = GetUserChoice();

                switch (userChoice)
                {
                    case "quit":
                        Console.WriteLine("Exiting the game");
                        return; 
                    case "skip":
                        Console.WriteLine("Skipping to the next level");
                        continue; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }


            }

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Game menu: ");
            Console.WriteLine("1- Quit");
            Console.WriteLine("2- Skip");
            Console.WriteLine("Enter your choice: ");

        }
        public static string GetUserChoice()
        { 
            return Console.ReadLine();
        }
    }
}
