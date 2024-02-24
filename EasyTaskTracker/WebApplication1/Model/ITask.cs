namespace EasyTaskTracker.Model
{
    public interface ITask
    {
        int Id { get; set; }
        string Name { get; set; } 
        List<User> Asssignies { get; set; }
        bool IsComplete { get; set; }
        string Description { get; set; }
        IStage Stage { get; set; }
    }
}