using Microsoft.AspNetCore.Identity;

namespace EasyTaskTracker.Model
{
    public class Task : ITask
    {
        private List<User> _asssignies;


        public Task()
        {
            _asssignies = new List<User>();
        }

        public Task(int id, string name, bool isComplete, string description, IStage stage, List<User> asssignies)
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
        public IStage Stage { get; set; }
        public List<User> Asssignies { get => _asssignies; set => _asssignies = value; }
    }
}
