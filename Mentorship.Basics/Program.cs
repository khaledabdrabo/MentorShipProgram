
namespace Mentorship.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I ignored handling the exceptions for this time only :)
            #region problem1__VariableInitialization
            /* VariableInitialization.InitializeTemperatureVariables (out double temperatureCelsius, out double temperatureFahrenheit);
            System.Console.WriteLine ($"temperature in Celsius :{temperatureCelsius}\ntemperature in Fahrenheit :{temperatureFahrenheit}"); */
            #endregion
            #region problem2_TypeConversion
            /* System.Console.WriteLine ("enter your age !");
            string stringName = Console.ReadLine ();
            TypeConversion.ConvertStringToInteger (stringName); */
            #endregion
            #region problem3_ArithmeticOperations
            //ArithmeticOperations.BasicCalculator(int.Parse(ReadLine()), int.Parse(ReadLine()),ReadLine().FirstOrDefault());
            #endregion
            #region problem4_LogicalOperators
            //WriteLine("enter the score then lives!");
            //bool isGameover = LogicalOperators.PlayerStatusCheck(int.Parse(ReadLine()), int.Parse(ReadLine()));
            //WriteLine($"isGameover =  {isGameover}");
            #endregion
            #region problem5_ConditionalStatements
            //Random rand = new();
            //bool seatAvailability = rand.Next(0,2)==0?false:true;
            //ConditionalStatements.SeatAvailabilityCheck(seatAvailability);
            #endregion
            #region problem6_SwitchStatement
            //WriteLine("Please Enter your choice");
            //int userChoice = int.Parse(ReadLine());
            //SwitchStatement.MenuOptionExecution(userChoice);
            #endregion
            #region problem7_WhileLoop
            //WhileLoop.UserInputValidation();
            #endregion
            #region problem8_ForLoop
            //List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ForLoop.IterateThroughList(list);
            #endregion
            #region problem9_DoWhileLoop
            //DoWhileLoop.RepeatBasedOnUserInput();
            #endregion
            #region problem10_ArraysInitialization
            //ArraysInitialization.InitializePlayerScoresArray();
            #endregion
            #region problem11_ArrayOperations
            //int [] playerScores = new[] {1,2,3,4,5,6,7,8,9};
            //ArrayOperations.CalculateAverageScore(playerScores);
            #endregion
        }
    }
}
