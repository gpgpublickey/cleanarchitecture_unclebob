using Agenda.UseCases.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.UseCases.Todo.AddTodoTask
{
    public class Interactor : IInputPort
    {
        private readonly IRepository<Entities.Todo.Task> _repository;
        public readonly IOutputPort _presenter;

        public Interactor(IRepository<Entities.Todo.Task> repository, IOutputPort presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public void Handle(InputDataRequest input)
        {
            HandleAsync(input).GetAwaiter().GetResult();
        }

        public async Task HandleAsync(InputDataRequest input)
        {
            await _repository.Add(new Entities.Todo.Task
            {
                Subject = input.Subject,
                Description = input.Description,
                DueDate = input.DueDate
            });


            await _presenter.HandleAsync(new OutputDataResponse
            {
                Subject = input.Subject,
                Description = input.Description,
                CreatedAt = DateTime.Now,
                CompletedAt = null
            });
        }
    }
}
