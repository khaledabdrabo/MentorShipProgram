using Problems_2.The_problems_from_27_to_46;
using System.Collections;
using System.Collections.Generic;

namespace Problems_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Linked List Implementation
            LinkedListImplementation.ImplementLinkedList();
            #endregion


            #region Lists - Sort Linked List
            LinkedList list = new LinkedList();
            list.AddNode(50);
            list.AddNode(30);
            list.AddNode(70);
            list.AddNode(20);
            list.AddNode(90);

            Console.WriteLine("Original Linked List:");
            list.DisplayList();

            LinkedList sortedList = LinkedListImplementation.ImplementLinkedList(list);
            Console.WriteLine("Sorted Linked List:");
            sortedList.DisplayList();
            #endregion

            #region Lists - Detect Loop in Linked List
            LinkedList list1 = new LinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);

            list.head.next.next.next = list.head.next;
            bool hasLoop = list.DetectLoop();
            Console.WriteLine("Does the linked list have a loop? " + hasLoop);
            #endregion

            #region Lists - Merge Two Sorted Lists
            LinkedList l1 = new LinkedList();
            l1.AddNode(1);
            l1.AddNode(2);
            l1.AddNode(3);

            LinkedList l2 = new LinkedList();
            l2.AddNode(4);
            l2.AddNode(5);
            l2.AddNode(6);

            LinkedList mergedList =  MergeSortedLists(l1, l2);

            Console.WriteLine("Merged Sorted List:");
            mergedList.DisplayList();
            #endregion

            #region Lists - Remove Nth Node from End
            LinkedList mylist = new LinkedList();
           mylist.AddNode(1);
           mylist.AddNode(2);
           mylist.AddNode(3);
           mylist.AddNode(4);
           mylist.AddNode(5);

            Console.WriteLine("Original Linked List:");
            list.DisplayList();

            int n = 2;
            LinkedList updatedList = RemoveNthNode(list, n);

            Console.WriteLine($"Linked List after removing {n}th node from end:");
            updatedList.DisplayList();
            #endregion

            #region Dictionaries - Word Frequency Counter
            string text = "My name is Ragheb. Ragheb likes people. Ragheb has Red-shirt";
            Dictionary<string, int> wordFrequencies = WordFrequencyCounter.CountWordFrequency(text);
            Console.WriteLine("The Word Frequencies: ");
            foreach (var word in wordFrequencies)
            {
                Console.WriteLine($"Word: {word.Key}, Frequency: {word.Value}");
            }
            #endregion

            #region Dictionaries - Merge Dictionaries
            Dictionary<int, string> dict1 = new Dictionary<int, string>()
            {
                {1, "one"},
                {2, "two"},
            };

            Dictionary<int, string> dict2 = new Dictionary<int, string>()
            {
                {2, "Modified Two"},
                {3, "Three"}
            };

            Dictionary<int, string> merged = MergeDictionaries.MergeTwoDictionaries(dict1, dict2);
            Console.WriteLine("Merged Dictionary: ");
            foreach (var words in merged)
            {
                Console.WriteLine($"Key: {words.Key}, Value: {words.Value}");
            }
            #endregion

            #region Dictionaries - Find Common Elements
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>()
            {
                {1,"Ragheb"},
                {2,"Ahmed"},
                {3,"Amr"}
            };

            Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
            {
                {2,"Ahmed"},
                {3,"Modified Omar"},
                {4,"Salem"}
            };

            Dictionary<int, string> commonElements = FindCommonElementsInDictionaries.FindCommonElements(dictionary1, dictionary2);
            Console.WriteLine("Common Elements: ");
            foreach (var word in commonElements)
            {
                Console.WriteLine($"Key: {word.Key}, Value: {word.Value}");
            }
            #endregion

            #region Dictionaries - Invert Dictionary
            Dictionary<int, string> originalDict = new Dictionary<int, string>()
            {
                {1,"Ragheb"},
                {2,"Amr"}
            };

            Dictionary<string, int> invertedDict = InvertDictionary.InvertedDictionry(originalDict);
            Console.WriteLine("Inverted Dictionary: ");
            foreach (var something in invertedDict)
            {
                Console.WriteLine($"Key: {something.Key}, Value: {something.Value}");
            }
            #endregion

            #region Dictionaries - Remove Key-Value Pair
            Dictionary<int, string> originaldict = new Dictionary<int, string>()
            {
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"}
            };
            int keyToRemove = 3;
            Dictionary<int, string> ModifiedDict = RemoveKeyValuePair.RemoveKeyValue(originaldict, keyToRemove);
            Console.WriteLine("Modified Dictionary:");
            foreach (var words in ModifiedDict)
            {
                Console.WriteLine($"Key: {words.Key}, Value: {words.Value}");
            }
            #endregion

            #region Queues - Implement Queue
            ImplementQueue.ImplementQueu();
            #endregion

            //#region Queues - Design Circular Queue

            //#endregion

            #region Queues - Print Binary Numbers
            int n = 4;
            PrintBinaryNumbers.PrintFirstNBinaryNumbers(n);
            #endregion

            #region Queues - Reverse First K Elements
            Queue<int> queue1 = new Queue<int>(new int[] { 1, 3, 5 });
            Queue<int> queue2 = new Queue<int>(new int[] { 2, 4, 6 });

            Queue<int> resultQueue = InterleaveTwoQueues.InterleaveQueues(queue1, queue2);
            // Display the interleaved queue
            Console.WriteLine("Interleaved Queue:");
            foreach (var element in resultQueue)
            {
                Console.WriteLine(element);
            }
            #endregion

            #region Stacks - Implement Stack
            ImplementStack.StackImplementation();
            #endregion

            #region Stacks - Evaluate Postfix Expression
            string expression = "23+";
            int result = EvaluatePostfixExpression.EvaluatePostfix(expression);
            Console.WriteLine($"Result: {result}");

            #endregion

            #region Stacks - Balanced Parentheses
            string expression1 = "{[()]}";
            Console.WriteLine($"Expression \"{expression1}\" is balanced: {(expression1)}");

            string expression2 = "{[(])}";
            Console.WriteLine($"Expression \"{expression2}\" is balanced: {(expression2)}");

            string expression3 = "()()()";
            Console.WriteLine($"Expression \"{expression3}\" is balanced: {(expression3)}");

            #endregion

            #region Stacks - Next Greater Element
            int[] array = { 4, 5, 2, 10, 8 };
            Dictionary<int, int> res =NextGreaterElement. FindNextGreaterElement(array);

            Console.WriteLine("Next Greater Element:");
            foreach (var num in res)
            {
                Console.WriteLine($"Element {num.Key}: Next Greater Element = {(num.Value == -1 ? "None" : num.Value.ToString())}");
            }
            #endregion

            #region Stacks - Sort Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(50);
            stack.Push(20);
            stack.Push(70);
            stack.Push(10);
            stack.Push(90);

            Console.WriteLine("Original Stack:");
            foreach (int item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Stack<int> sortedStack =SortStack.SortedStack(stack);

            Console.WriteLine("Sorted Stack:");
            foreach (int item in sortedStack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            #endregion

        }
    }
}
