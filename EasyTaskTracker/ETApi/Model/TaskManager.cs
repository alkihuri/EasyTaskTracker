using EasyTaskTracker.Model;

public class TaskManager : ITaskManager
{

    private ITaskRepository _taskRepository;

    public TaskManager(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void AddTask(TrackerTask task)
    {
        _taskRepository.AddTask(task);
    }
    public void DeleteTask(TrackerTask task)
    { 
        _taskRepository.DeleteTask(task);    
    }
    public void UpdateTask(TrackerTask task)
    {
        // Update task in database
    }
    public void AssignTask(TrackerTask task, User user)
    {
        // Assign task to user
    }
    public void ChangeTaskStage(TrackerTask task, StageEnum stage)
    {
        // Change task stage
    }
    public void ChangeTaskStatus(TrackerTask task, bool status)
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
    public void AddTaskToRole(Role role, TrackerTask task)
    {
        // Add task to role
    }
    public void RemoveTaskFromRole(Role role, TrackerTask task)
    {
        // Remove task from role
    }
    public void AddUserToTask(TrackerTask task, User user)
    {
        // Add user to task
    }
    public void RemoveUserFromTask(TrackerTask task, User user)
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
    public void AddTaskToUser(User user, TrackerTask task)
    {
        // Add task to user
    }
    public void RemoveTaskFromUser(User user, TrackerTask task)
    {
        // Remove task from user
    }
    public void AddRoleToTask(TrackerTask task, Role role)
    {
        // Add role to task
    }
    public void RemoveRoleFromTask(TrackerTask task, Role role)
    {
        // Remove role from task
    }

    public TrackerTask CreateTask(string name, string description, StageEnum stage)
    {
        throw new NotImplementedException();
    }

    public TrackerTask GetTask(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TrackerTask> GetTasks()
    {
        return _taskRepository.GetTasks();
    }

     

    public StageEnum CreateStage(StageEnum name)
    {
        throw new NotImplementedException();
    }

    public StageEnum GetStage(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<StageEnum> GetStages()
    {
        throw new NotImplementedException();
    }

    public void UpdateStage(StageEnum stage)
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

    public void AddTask(Task task)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        // Delete user from database     
    }
}
