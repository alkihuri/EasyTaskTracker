using EasyTaskTracker.Model;
using TrackerTask = EasyTaskTracker.Model.TrackerTask;

public class TaskRepository : ITaskRepository
{
    private readonly string PATH;
    private TaskContext _context;

    public TaskRepository(TaskContext context)
    {
        _context = context;
    }

    public void AddTask(EasyTaskTracker.Model.TrackerTask task)
    {
        _context.Tasks.Add(task);
        _context.SaveChanges();
    }

    public List<TrackerTask> GetAllTasks()
    {
        return _context.Tasks.ToList();
    }

    public void AddRole(Role role)
    { 
        //_context.Roles.Add(role);
        //_context.SaveChanges();
    }

  

    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public void AssignRole(User user, Role role)
    {
        throw new NotImplementedException();
    }

    public void AssignTask(TrackerTask task, User user)
    {
        throw new NotImplementedException();
    }

    public void ChangeTaskStage(TrackerTask task, StageEnum stage)
    {
        throw new NotImplementedException();
    }

    public void ChangeTaskStatus(TrackerTask task, bool status)
    {
        throw new NotImplementedException();
    }

    public void RemoveRole(Role role)
    {
        throw new NotImplementedException();
    }

    public void RemoveTask(TrackerTask task)
    {
        throw new NotImplementedException();
    }

    public void RemoveUser(User user)
    {
        throw new NotImplementedException();
    }

    public void UpdateRole(Role role)
    {
        throw new NotImplementedException();
    }

    public void UpdateTask(TrackerTask task)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public List<TrackerTask> GetTasks()
    { 
        return _context.Tasks.ToList();
    }

    public void DeleteTask(TrackerTask task)
    {
        _context.Tasks.Remove(task);
        _context.SaveChanges();
    }
}