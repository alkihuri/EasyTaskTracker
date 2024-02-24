using EasyTaskTracker.Model;
using Microsoft.AspNetCore.Mvc;

namespace EasyTaskTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StagesController : ControllerBase
    {
        private readonly ITaskManager _taskManager;

        public StagesController(ITaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        [HttpGet]
        public IEnumerable<StageEnum> GetStages()
        {
            return _taskManager.GetStages();
        }
    }
}
