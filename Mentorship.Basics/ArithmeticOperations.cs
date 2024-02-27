namespace Mentorship.Basics;
public class ArithmeticOperations
{
    public static void BasicCalculator(double num1, double num2,char operation)
    {
        switch(operation) 
        {
            case '+' :
                WriteLine(num1+num2);
                break;
            case '-' :
                WriteLine(num1-num2);
                break;
            case '*':
                WriteLine(num1*num2);
                break;
            case '/':
                WriteLine(num1/num2);
                break;
            default: WriteLine("invalid operation");
                break;
        }
    }
}

