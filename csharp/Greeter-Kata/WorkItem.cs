namespace Greeter_Kata
{
    public class WorkItem
    {
        public string Description { get; }
        public int Priority { get; }

        public WorkItem(string description, int priority)
        {
            Description = description;
            Priority = priority;
        }
    }
}