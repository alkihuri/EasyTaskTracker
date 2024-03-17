public interface ITaskRepository
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task); 
    void DeleteTask(int taskId);
    void Complete(int id);
} 