using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.UseCases.Todo.AddTodoTask.Interfaces
{
    public interface IService
    {
        Task AddTask(InputDataRequest request);

        Task ValidateInputs(InputDataRequest request);
    }
}
