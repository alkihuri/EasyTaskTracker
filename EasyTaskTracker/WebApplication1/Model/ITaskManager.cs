using EasyTaskTracker.Model;

public interface ITaskManager
{
    ITask CreateTask(string name, string description, IStage stage);
    ITask GetTask(int id);
    void AddTask(ITask task);
    IEnumerable<ITask> GetTasks();
    void UpdateTask(ITask task);
    void DeleteTask(int id);
    IStage CreateStage(StageEnum name);
    IStage GetStage(int id);
    IEnumerable<IStage> GetStages();
    void UpdateStage(IStage stage);
    void DeleteStage(int id);

    User CreateUser(string name);
    User GetUser(int id);
    IEnumerable<User> GetUsers();
    void UpdateUser(User user);
    void DeleteUser(int id);

}