using Agenda.Presenters.AddTodoTask;
using Agenda.UseCases.Todo.AddTodoTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.ApiRest.Controllers
{
    [ApiController]
    [Route("todos")]
    public class TodosApiController : ControllerBase
    {
        private readonly ILogger<TodosApiController> _logger;
        private readonly Agenda.Controllers.TodoTasksController _controller;

        public TodosApiController(ILogger<TodosApiController> logger, Agenda.Controllers.TodoTasksController controller)
        {
            _logger = logger;
            _controller = controller;
        }

        [HttpPost]
        public async Task<AddBrowserViewModel> AddTodoTask(InputDataRequest request)
        {
            return await _controller.Add(request);
        }
    }
}
