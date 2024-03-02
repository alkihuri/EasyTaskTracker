using EasyTaskTracker.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EasyTaskTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskManager _taskManager;

        public TasksController(ITaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        [HttpGet]
        [Route("tasks/getall")]
        public IActionResult GetTasks()
        {
            return Ok(_taskManager.GetTasks());
        }

        [HttpGet] 
        [Route("tasks/getask")]
        public IActionResult GetTask(int id)
        {
            Console.WriteLine("GetTask");

            return Ok(_taskManager.GetTask(id));
        }

        [HttpPost] 
        [Route("tasks/createtask")]
        public IActionResult CreateTask([FromBody] TrackerTask task)
        {
            _taskManager.AddTask(task);
            return Ok();    
        }

        [HttpGet]
        [Route("tasks/createtaskrandom")]
        public IActionResult CreateTask(int id)
        {
            var task = new TrackerTask()
            {
                Id = id,
                Name = "Task" + id,
                IsComplete = false,
                Description = "Description" + id,
                Stage = StageEnum.ToDo
            };
            _taskManager.AddTask(task);
             return Ok();
        }

        [HttpPut("{id}")]
        public void UpdateTask(int id, [FromBody] TrackerTask task)
        {
            task.Id = id; // Установка ID из URL
            _taskManager.UpdateTask(task);
        }

        [HttpGet]
        [Route("tasks/deletetask")]
        public void DeleteTask(int id)
        {
            var task = _taskManager.GetTasks().ToList().Find(x => x.Id == id); 
            Console.WriteLine("DeleteTask");  
            if(task != null)
                _taskManager.DeleteTask(task);   
            else
                Console.WriteLine("Task not found");
        }
    }
}
