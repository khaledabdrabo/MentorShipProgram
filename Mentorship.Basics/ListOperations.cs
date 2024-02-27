using System.Threading.Tasks;

namespace Mentorship.Basics;

internal class ListOperations
{
    public static void ManageToDoList(List<Task>tasks)
    {
        // add tasks
        AddTask(tasks,new(1, "task1", "first task"));
        AddTask(tasks, new(2, "task2", "second task"));
        AddTask(tasks, new(3, "task3", "third task"));
        // delete task
        RemoveTask(tasks,tasks[2]);
        // dispaly task
        DisplayTasks(tasks);
    }
    private static void AddTask(List<Task> tasks,Task newTask)
    {
        tasks.Add(newTask);
    }
    private static void RemoveTask(List<Task> tasks, Task taskToRemove)
    {
        tasks.Remove(taskToRemove);
    }
    private static void DisplayTasks(List<Task> tasks)
    {
        foreach (Task task in tasks)
        {
            WriteLine(task);
        }
    }
}