using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class SwitchStatement
    {
        public static void MenuOptionExecution(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                  Console.WriteLine("Executing action for choice 1");
                    break;

                case 2:
                    Console.WriteLine("Executing action for choice 2");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
