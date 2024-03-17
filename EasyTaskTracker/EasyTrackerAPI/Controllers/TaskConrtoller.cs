using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   


public class TaskContrller : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public TaskContrller(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }   

    [HttpGet("/api/tasks/getall")]
    public IEnumerable<TrackerTask> GetAll()
    {
        return _taskManager.GetAllTasks();
    }

    [HttpGet("/api/tasks/get/{id}")]
    public TrackerTask Get(int id)
    {
        return _taskManager.GetTaskById(id);
    }


    [HttpPost("/api/tasks/add")]
    public void Create([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
    }

    [HttpGet("/api/tasks/delete/{id}")]
    public void Delete(int id)
    {  
        _taskManager.DeleteTask(id); 
    }

    [HttpGet("/api/tasks/complete/{id}")]
    public void CompleteTask(int id)
    {
        _taskManager.Complete(id);
    }



    [HttpGet("/api/tasks/addrandom/{id}")]
    public void User(int id)
    {
         for(int x = 0 ; x < id;x++ )
         {
            int lastTaskID = 0 ;
            try
            {
                var tasks = _taskManager.GetAllTasks(); 
                lastTaskID = (int)tasks.Max(t => t.ID);   
            } 
            catch
            {
                lastTaskID = 0; 
            }
            
            var newTask = new TrackerTask();
            var randomName = "Task #" + (lastTaskID + x).ToString();
            newTask.ID = lastTaskID + x;       
            newTask.Name = randomName;  
            newTask.Description = "This is a random task";   
            newTask.DueDate = new DateTime();
            newTask.AssignedUser = new User("alkihuri");
            _taskManager.AddTask(newTask); 
         }
    }

}