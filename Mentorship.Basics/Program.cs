
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;

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
            #region problem12_ListsInitialization
            //ListsInitialization.InitializeTaskList();
            #endregion
            #region problem13_ListOperations
            //List<Task> tasks = new();
            //ListOperations.ManageToDoList(tasks);
            #endregion
            #region problem14_NestedControlFlow
            //string state = ReadLine();
            //NestedControlFlow.SimulateTrafficLight(state);
            #endregion
            #region problem15_NestedLoops
            //WriteLine("Enter rows then columns !");
            //int rows = int.Parse(ReadLine());
            //int columns = int.Parse(ReadLine());
            //NestedLoops.CreatePattern(rows, columns);
            #endregion
            #region problem16_BreakAndContinue
            //BreakAndContinue.GameOptions();
            #endregion
            #region problem17_BreakAndContinue
            //string userInput = ReadLine();
            //ErrorHandling.HandleInvalidInput(userInput);
            #endregion
            #region problem18_RandomNumberGeneration
            //string[] questions = { "question 1", "question 2", "question 3", "question 4" };
            //RandomNumberGeneration.GenerateRandomQuestion(questions);
            #endregion
            #region problem20_MultiDimensionalArrays
            //int rows = int.Parse(ReadLine());
            //int columns = int.Parse(ReadLine());
            //MultiDimensionalArrays.InitializeGameBoard(rows, columns);
            #endregion
            #region problem21_ArrayReverse
            //int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //ArrayReverse.ReverseArray(array);
            #endregion
            #region problem22_FindMaximumElement
            //long[] array = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L };
            //FindMaximumElement.FindMaxElement(array);
            #endregion
            #region problem23_MergeArrays
            //int[] array1 = new[] { 1, 2, 3, 4, 5 };
            //int[] array2 = new[] { 6, 7, 8, 9 };
            //MergeArrays.MergeTwoArrays(array1, array2);
            #endregion
            #region problem24_RemoveDuplicatesFromArray
            //int[] array = new [] { 1, 1, 2, 2, 3, 4, 5, 5 };
            //int[] result = RemoveDuplicatesFromArray.RemoveDuplicates(array);
            //foreach (int item in result)
            //{
            //    Write(item + " ");
            //}
            #endregion
            #region problem25_TwoSumProblem
            //int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int target = 15;
            //KeyValuePair<int,int> result = TwoSumProblem.FindTwoSum(array, target);
            //WriteLine($"the two numbers are {result.Key} and {result.Value}");
            #endregion
            #region problem26_LinkedListImplementation
            //LinkedListImplementation.ImplementLinkedList();
            #endregion
            #region problem27_SortLinkedList
            //linkedList<int> myLinkedList = new(new[] {3,4,5,1,2});
            //SortLinkedList.SortLinkedListFunction(myLinkedList);
            //myLinkedList.DisplayList();
            #endregion
            #region problem28_DetectLoopInLinkedList
            //linkedList<int> myLinkedList = new(new[] {3,4,5,1,2});
            //bool result = DetectLoopInLinkedList.DetectLoop(myLinkedList);
            //WriteLine(result);
            #endregion
            #region problem29_MergeSortedLists
            //linkedList<int> list1 = new(new[] { 1, 2, 3, 4, 5 });
            //linkedList<int> list2 = new(new[] { 6, 7, 8, 9 });
            //var mergedList = MergeSortedLists.MergeSortedListsFunction(list1, list2);
            //mergedList.DisplayList();
            #endregion
            #region problem31_WordFrequencyCounter
            //WordFrequencyCounter.CountWordFrequency("i will get a good job because i am a good developer");
            #endregion
            #region problem32_MergeDictionaries
            //Dictionary<int, int> dict1 = new(new KeyValuePair<int, int>[] { new(1, 2), new (3,4) });
            //Dictionary<int, int> dict2 = new(new KeyValuePair<int, int>[] { new(5, 6), new(7, 8) });
            //Dictionary<int, int> mergedDictionary = MergeDictionaries.MergeTwoDictionaries(dict1, dict2);
            #endregion
            #region problem33_FindCommonElementsInDictionaries
            //Dictionary<int, int> dict1 = new(new KeyValuePair<int, int>[] { new(1, 2), new (3,4) });
            //Dictionary<int, int> dict2 = new(new KeyValuePair<int, int>[] { new(1, 2), new(7, 8) });
            //Dictionary<int, int> commonElements = FindCommonElementsInDictionaries.FindCommonElements(dict1, dict2);
            #endregion
            #region problem34_InvertDictionary
            //Dictionary<int, int> originalDictionary = new(new KeyValuePair<int, int>[] { new(1, 2), new(3, 4) });
            //var invertedDict = InvertDictionary.InvertDictionaryFunction(originalDictionary);
            #endregion
            #region problem35_RemoveKeyValuePair
            //Dictionary<int, int> originalDictionary = new(new KeyValuePair<int, int>[] { new(1, 2), new(3, 4) });
            //int keyToRemove = 3;
            //RemoveKeyValuePair.RemoveKeyValuePairFunction(originalDictionary, keyToRemove);
            #endregion
        }
    }
}
