using Microsoft.AspNetCore.Mvc;

namespace ToDoListTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetToDo")]
        public string Get(int id)
        {
            return $"ToDo {id}";
        }
    }
}