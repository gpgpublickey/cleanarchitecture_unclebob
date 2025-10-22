using Agenda.Presenters.Todo;
using Agenda.UseCases.Todo.AddTodoTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.ApiRest.Controllers
{
    [ApiController]
    [Route("todos")]
    public class TodosApiController : ControllerBase
    {
        private readonly ILogger<TodosApiController> _logger;
        private readonly Agenda.Controllers.TodosController _controller;

        public TodosApiController(ILogger<TodosApiController> logger, Agenda.Controllers.TodosController controller)
        {
            _logger = logger;
            _controller = controller;
        }

        [HttpPost]
        public async Task<BrowserViewModel> AddTodoTask(InputDataRequest request)
        {
            return await _controller.AddTodoTask(request);
        }
    }
}
