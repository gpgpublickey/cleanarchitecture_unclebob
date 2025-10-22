using Agenda.UseCases.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.UseCases.Todo.AddTodoTask.Interfaces
{
    public interface IOutputPort<T> : IPort<OutputDataResponse>
    {
        T ViewModel { get; }
    }
}
