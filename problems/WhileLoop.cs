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

