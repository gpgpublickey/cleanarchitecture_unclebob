using Agenda.Presenters.AddTodoTask;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.Controllers
{
    public class TodoTasksController(IInputPort _interactor, AddBrowserPresenter _addTodoPresenter)
    {
        public async Task<AddBrowserViewModel> Add(InputDataRequest request)
        {
            await _interactor.HandleAsync(request);

            return _addTodoPresenter.ViewModel;
        }
    }
}
