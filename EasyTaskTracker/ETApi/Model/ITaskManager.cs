using EasyTaskTracker.Model;

public interface ITaskManager
{
    TrackerTask CreateTask(string name, string description, StageEnum stage);
    TrackerTask GetTask(int id);
    void AddTask(TrackerTask task);
    IEnumerable<TrackerTask> GetTasks();
    void UpdateTask(TrackerTask task);
    void DeleteTask(TrackerTask task);
    StageEnum CreateStage(StageEnum name);
    StageEnum GetStage(int id);
    IEnumerable<StageEnum> GetStages();
    void UpdateStage(StageEnum stage);
    void DeleteStage(int id);

    User CreateUser(string name);
    User GetUser(int id);
    IEnumerable<User> GetUsers();
    void UpdateUser(User user);
    void DeleteUser(int id);

}