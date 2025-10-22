using Agenda.Presenters.Todo;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.Controllers
{
    public class TodosController
    {
        private readonly IOutputPort<BrowserViewModel> _presenter;
        private readonly IInputPort _interactor;

        public TodosController(IOutputPort<BrowserViewModel> presenter, IInputPort interactor)
        {
            _presenter = presenter;
            _interactor = interactor;
        }

        public async Task<BrowserViewModel> AddTodoTask(InputDataRequest request)
        {
            await _interactor.HandleAsync(request);
            await _presenter.HandleAsync(_interactor.Response);
            return _presenter.ViewModel;
        }
    }
}
