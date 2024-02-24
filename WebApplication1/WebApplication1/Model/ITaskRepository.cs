using EasyTaskTracker.Model;

public interface ITaskRepository
{
    void AddTask(ITask task);
    void RemoveTask(ITask task);
    void UpdateTask(ITask task);
    void AssignTask(ITask task, User user);
    void ChangeTaskStage(ITask task, IStage stage);
    void ChangeTaskStatus(ITask task, bool status);
    void AddUser(User user);
    void RemoveUser(User user);
    void UpdateUser(User user);
    void AddRole(Role role);
    void RemoveRole(Role role);
    void UpdateRole(Role role);
    void AssignRole(User user, Role role);
}