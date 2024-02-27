using System.Collections.Generic;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables Initialization
            VariableInitialization variableInitialization = new VariableInitialization();
            variableInitialization.InitializeTemperatureVariables();
            variableInitialization.DisplayTemperature();
            #endregion

            #region Type Conversion
            TypeConversion conversion = new TypeConversion();
            Console.Write("Enter your Age:");
            string ageWithString = Console.ReadLine();

            try
            {
                int ageWithInt = conversion.ConvertStringToInteger(ageWithString);
                Console.WriteLine($"Your Age with Integer is :{ageWithInt}");

            }
            catch (Exception)
            {
                Console.WriteLine("Invaild Age");
            }
            #endregion

            #region Arithmetic Operations
            Console.WriteLine("Enter num1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation:");
            string operation = Console.ReadLine();

            ArithmeticOperations calc = new ArithmeticOperations();
            double result = calc.BasicCalcultor(num1,num2,"operation");
            Console.WriteLine($"The Result is {result}");

            #endregion

            #region Logical Operators

            bool gameOver = LogicalOperators.PlayerStatusCheck(200,0);
            Console.WriteLine(gameOver);
            #endregion

            #region Conditional statements
            Conditional_Statements.SeatAvailabilityCheck(true);
            #endregion

            #region Switch Statement
            SwitchStatement.MenuOptionExecution(2);
            #endregion

            //#region While Loop
                

            //#endregion


            #region For Loop
                List<string> list = new List<string> { "item1", "item2" , "item3"};
                    ForLoop.IterateThroughList(list);

            #endregion

            #region Do-While Loop
            DoWhileLoop.RepeatBasedOnUserInput();
            #endregion

            #region Arrays Initialization

           int[] score =  ArraysInitialization.InitializePlayerScoresArray();
            foreach(int i in score)
            {
                Console.WriteLine($"The Initialized player scored:{i}");
            }

            #endregion

            #region Array Operations
            int[] playScores = { 45, 34, 29, 55, 65 };
            
            double average = ArrayOperations.CalculateAverageScore(playScores);
            Console.WriteLine($"The average score is {average}");
            #endregion


            //#region Lists Initialization
            WhileLoop.UserInputValidation();
            //#endregion

            #region List Operations
            List<string> tasks = new List<string>();
                ListOperations.ManageToDoList(tasks);
            #endregion

            #region Nested Control Flow
            NestedControlFlow.SimulateTrafficLight("red");
            #endregion

            #region Nested Loops
            
            NestedLoops.CreatePattern("5","3");

            #endregion

            #region Break and Continue

            BreakAndContinue.GameOptions();

            #endregion

            #region Error Handling
            ErrorHandling.HandleInvalidInput("3");
            ErrorHandling.HandleInvalidInput("ragheb");

            #endregion

            


        }
    }
}
