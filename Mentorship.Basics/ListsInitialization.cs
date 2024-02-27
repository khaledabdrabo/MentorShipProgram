namespace Mentorship.Basics;

internal class ListsInitialization
{
    public static void InitializeTaskList()
    {
        List<Task> tasks = new List<Task>()
        {
            new Task(1,"task1","the first task"),
            new Task(2,"task2","the second task"),
            new Task(3,"task3","the third task")
        };

        foreach(var item in tasks)
        {
            WriteLine(item);
        }
    }
   
}
