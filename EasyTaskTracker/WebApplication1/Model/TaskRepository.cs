using EasyTaskTracker.Model;

public class TaskRepository : ITaskRepository
{
    private readonly string PATH;
    private TaskContext _context; 

    public TaskRepository(TaskContext context)
    {
        _context = context;
    }
     
    public void AddRole(Role role)
    { 

    }

    public void AddTask(ITask task)
    { 
    }

    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public void AssignRole(User user, Role role)
    { 
        throw new NotImplementedException();
    }

    public void AssignTask(ITask task, User user)
    {
        throw new NotImplementedException();
    }

    public void ChangeTaskStage(ITask task, IStage stage)
    {
        throw new NotImplementedException();
    }

    public void ChangeTaskStatus(ITask task, bool status)
    {
        throw new NotImplementedException();
    }

    public void RemoveRole(Role role)
    {
        throw new NotImplementedException();
    }

    public void RemoveTask(ITask task)
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

    public void UpdateTask(ITask task)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}