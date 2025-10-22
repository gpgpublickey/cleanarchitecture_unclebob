using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.Presenters.Todo
{
    public class BrowserPresenter : IOutputPort<BrowserViewModel>
    {
        public BrowserViewModel ViewModel { get; set; }

        public void Handle(OutputDataResponse input)
        {
            ViewModel = new BrowserViewModel(input);
        }

        public async Task HandleAsync(OutputDataResponse input)
        {
            await Task.Run(() => Handle(input));
        }
    }
}
