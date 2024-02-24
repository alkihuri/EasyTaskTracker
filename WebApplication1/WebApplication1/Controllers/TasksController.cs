using EasyTaskTracker.Model;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<ITask> GetTasks()
        {
            return _taskManager.GetTasks();
        }

        [HttpGet("{id}")]
        public ITask GetTask(int id)
        {
            return _taskManager.GetTask(id);
        }

        [HttpPost]
        public void CreateTask([FromBody] ITask task)
        {
            _taskManager.AddTask(task);
        }

        [HttpPut("{id}")]
        public void UpdateTask(int id, [FromBody] ITask task)
        {
            task.Id = id; // Установка ID из URL
            _taskManager.UpdateTask(task);
        }

        [HttpDelete("{id}")]
        public void DeleteTask(int id)
        {
            _taskManager.DeleteTask(id);
        }
    }
}
