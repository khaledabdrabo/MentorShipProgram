using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class ArithmeticOperations
    {
        public  double BasicCalcultor(double num1, double num2, string operation)
        {
            double result = 0;
            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                    throw new Exception("Invaild operation");
            }
            return result;
        }
        
    }
   
}

