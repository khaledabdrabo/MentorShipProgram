using problems.Arrays___Find_Maximum_Element;
using problems.Arrays___Remove_Duplicates;
using problems.Arrays___Reverse_Array;
using problems.Arrays___Two_Sum_Problem;
using problems.File_Handling;
using problems.Multi_dimensional_Arrays;
using problems.Random_Number_Generation;
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

            #region While Loop
            WhileLoop.UserInputValidation();
            Console.WriteLine("Valid Input,, THANKS");

            #endregion


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


            #region Lists Initialization
            List<Task> myTasks = ListInitialization.InitializeTaskList();
            //myTasks.Add(new Task("task1"));
            //myTasks.Add(new Task("task2"));

            // Access and manipulate tasks
            Console.WriteLine(myTasks[0]); 
            myTasks.RemoveAt(1);
            #endregion

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

            #region RandomNumberGeneration
            string[] questions =
            {
                "What's your name?",
                "Where are you from?",
                "What's your college?",
                "What's the best friend for you?"
            };
            string randomQuestion = RandomNumberGeneration.GenerateRandomQuestion(questions);
            Console.WriteLine($"Random Question: {randomQuestion}");
            #endregion

            #region File Handling
            string filePath = "C:\\Users\\raytheon\\Desktop filename.txt";
            FileHandling.ReadAndProcessDataFromFile(filePath);


            #endregion

            #region Multi-dimensionalArrays
            int[,] gameBoard = Multi_dimensionalArrays.InitializeGameBoard(4,5);
            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);
            Console.WriteLine($"Dimensions: {rows} rows , {cols} columns");
            #endregion

            #region Arrays - Reverse Array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ReverseArray.ArrayReverse(array);
            Console.WriteLine("The Reversed Array: ");
            foreach(var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();
            #endregion

            #region Arrays - Find Maximum Element
            int[] arr1 = {3,4,5,6,7,8,9};
            int maxElement = FindMaximumElement.FindMaxElement(arr1);
            Console.WriteLine($"The Maximum Element : {maxElement}");
            #endregion

            #region Remove Duplicates
            int[] array1 = { 1, 2, 3, 4, 2, 3, 5, 6, 4 };
            int [] result1 = RemoveDuplicatesFromArray.RemoveDuplicates(array1);
            Console.WriteLine("After Removing duplicates: ");
            foreach (int element in result1 )
            {
                Console.Write(element);
            }
            Console.WriteLine();
            #endregion

            #region Two Sum problems
            int[] arr = { 1, 2, 3, 4 };
            int target = 3;
            int[] indexes = Two_Sum_Problem.FindTwoSum(arr,target);
            Console.WriteLine(indexes);
            #endregion

           

        }
    }
}
