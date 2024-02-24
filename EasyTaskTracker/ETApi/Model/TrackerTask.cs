using Microsoft.AspNetCore.Identity;

namespace EasyTaskTracker.Model
{
    public class TrackerTask
    {
        private List<User> _asssignies;


        public TrackerTask()
        {
            _asssignies = new List<User>();
        }

        public TrackerTask(int id, string name, bool isComplete, string description, StageEnum stage, List<User> asssignies)
        {
            Id = id;
            Name = name;
            IsComplete = isComplete;
            Description = description;
            Stage = stage;
            Asssignies = asssignies;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public string Description { get; set; }
        public StageEnum Stage { get; set; }
        public List<User> Asssignies { get => _asssignies; set => _asssignies = value; }
    }
}
