using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.Presenters.AddTodoTask
{
    public class AddBrowserPresenter : IOutputPort
    {
        public AddBrowserViewModel ViewModel { get; set; }

        public void Handle(OutputDataResponse input)
        {
            ViewModel = new AddBrowserViewModel(input);
        }

        public async Task HandleAsync(OutputDataResponse input)
        {
            Handle(input);
            await Task.CompletedTask;
        }
    }
}
