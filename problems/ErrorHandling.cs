using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class ErrorHandling
    {
        public static void HandleInvalidInput(string userInput)
        {
            try
            {
                ProcessUserInput(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        public static void ProcessUserInput(string userInput)
        {
            
            int number = int.Parse(userInput);
            Console.WriteLine($"You entered: {number}");
        }
    }
}
