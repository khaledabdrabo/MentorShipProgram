using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class DoWhileLoop
    {
        public static void RepeatBasedOnUserInput()
        {
            bool repeat;

            do
            {
                ExecuteBlockOfCode();

                repeat = GetUserConfirmation();
            } while (repeat);
        }

        
        private static void ExecuteBlockOfCode()
        {

            Console.WriteLine("Executing the block of code...");
        }

        
        private static bool GetUserConfirmation()
        {
            Console.WriteLine("Do you want to repeat? (y/n):");
            string input = Console.ReadLine();
            return input == "y";
        }
    }
}
