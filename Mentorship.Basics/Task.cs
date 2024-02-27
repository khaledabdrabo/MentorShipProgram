namespace Mentorship.Basics;

internal class Task
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Task() { }

    public Task(int iD, string name, string description)
    {
        ID = iD;
        Name = name;
        Description = description;
    }
    public override string ToString()
    {
        return $"ID = {ID}, Name = {Name}, Description = {Description} ";
    }
}