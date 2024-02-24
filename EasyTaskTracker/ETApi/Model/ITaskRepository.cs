using EasyTaskTracker.Model;

public interface ITaskRepository
{
    void AddTask(TrackerTask task);
    void RemoveTask(TrackerTask task);
    void UpdateTask(TrackerTask task);
    void AssignTask(TrackerTask task, User user);
    void ChangeTaskStage(TrackerTask task, StageEnum stage);
    void ChangeTaskStatus(TrackerTask task, bool status);
    void AddUser(User user);
    void RemoveUser(User user);
    void UpdateUser(User user);
    void AddRole(Role role);
    void RemoveRole(Role role);
    void UpdateRole(Role role);
    void AssignRole(User user, Role role);
    List<TrackerTask> GetTasks();
}