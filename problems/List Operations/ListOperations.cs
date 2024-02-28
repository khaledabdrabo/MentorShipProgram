using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class ListOperations
    {
        public static void ManageToDoList(List<string> tasks)
        {
            //Add tasks
            AddTask(tasks, "task 1");
            AddTask(tasks, "task 2");
            AddTask(tasks, "task 3");
            AddTask(tasks, "task 4");

            //Remove tasks
            RemoveTask(tasks, "task 1");

            //Display tasks
            DisplayTasks(tasks);

        }
        public static void AddTask(List<string> tasks, string newTask)
        {
            tasks.Add(newTask);
        }
        public static void RemoveTask(List<string> tasks, string taskToRemove)
        {
            tasks.Remove(taskToRemove);
        }

        public static void DisplayTasks(List<string> tasks)
        {
            foreach (string task in tasks)
            {
                Console.WriteLine($"The task is : {task}");
            }
        }
    }
}
