using Microsoft.AspNetCore.Identity;

namespace EasyTaskTracker.Model
{
    public class Task : ITask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public string Description { get; set; }
        public IStage Stage { get; set; }
    }
}
