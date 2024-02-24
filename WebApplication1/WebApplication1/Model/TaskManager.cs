using EasyTaskTracker.Model;

public class TaskManager : ITaskManager
{

    private ITaskRepository _taskRepository;

    public TaskManager(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void AddTask(ITask task)
    {
        // Add task to database
    }
    public void RemoveTask(ITask task)
    {
        // Remove task from database
    }
    public void UpdateTask(ITask task)
    {
        // Update task in database
    }
    public void AssignTask(ITask task, User user)
    {
        // Assign task to user
    }
    public void ChangeTaskStage(ITask task, IStage stage)
    {
        // Change task stage
    }
    public void ChangeTaskStatus(ITask task, bool status)
    {
        // Change task status
    }
    public void AddUser(User user)
    {
        // Add user to database
    }
    public void RemoveUser(User user)
    {
        // Remove user from database
    }
    public void UpdateUser(User user)
    {
        // Update user in database
    }
    public void AddRole(Role role)
    {
        // Add role to database
    }
    public void RemoveRole(Role role)
    {
        // Remove role from database
    }
    public void UpdateRole(Role role)
    {
        // Update role in database
    }
    public void AssignRole(User user, Role role)
    {
        // Assign role to user
    }
    public void RemoveRoleFromUser(User user, Role role)
    {
        // Remove role from user
    }
    public void AddTaskToRole(Role role, ITask task)
    {
        // Add task to role
    }
    public void RemoveTaskFromRole(Role role, ITask task)
    {
        // Remove task from role
    }
    public void AddUserToTask(ITask task, User user)
    {
        // Add user to task
    }
    public void RemoveUserFromTask(ITask task, User user)
    {
        // Remove user from task
    }
    public void AddUserToRole(Role role, User user)
    {
        // Add user to role
    }
    public void RemoveUserFromRole(Role role, User user)
    {
        // Remove user from role
    }
    public void AddTaskToUser(User user, ITask task)
    {
        // Add task to user
    }
    public void RemoveTaskFromUser(User user, ITask task)
    {
        // Remove task from user
    }
    public void AddRoleToTask(ITask task, Role role)
    {
        // Add role to task
    }
    public void RemoveRoleFromTask(ITask task, Role role)
    {
        // Remove role from task
    }

    public ITask CreateTask(string name, string description, IStage stage)
    {
        throw new NotImplementedException();
    }

    public ITask GetTask(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITask> GetTasks()
    {
        throw new NotImplementedException();
    }

    public void DeleteTask(int id)
    {
        throw new NotImplementedException();
    }

    public IStage CreateStage(StageEnum name)
    {
        throw new NotImplementedException();
    }

    public IStage GetStage(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IStage> GetStages()
    {
        throw new NotImplementedException();
    }

    public void UpdateStage(IStage stage)
    {
        throw new NotImplementedException();
    }

    public void DeleteStage(int id)
    {
        throw new NotImplementedException();
    }

    public User CreateUser(string name)
    {
        throw new NotImplementedException();
    }

    public User GetUser(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}
