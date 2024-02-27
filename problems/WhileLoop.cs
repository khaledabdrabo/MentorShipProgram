using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace problems
{
    public class WhileLoop
    {
        //       Class: WhileLoop
        //Function: UserInputValidation()

        //// Continuously prompt the user for input until a valid option is selected
        //validOption = false

        //while validOption is false
        // userInput = GetUserInput()

        // // Validate user input
        // if userInput is valid
        // validOption = true
        // else
        // Console.WriteLine("Invalid input. Please try again.")
        public static void UserInputValidation()
        {
            bool validOption = false;
            while (!validOption)
            {
                string userInput = GetUserInput();
                if (!string.IsNullOrEmpty(userInput))
                    validOption = true;
                else
                    Console.WriteLine("Invalid input. Please try again.");
            }
        }
        public static string GetUserInput()
        {
            Console.WriteLine("Enter your input: ");
            return Console.ReadLine();
        }
    }
}

