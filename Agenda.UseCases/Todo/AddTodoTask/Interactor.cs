using Agenda.UseCases.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.UseCases.Todo.AddTodoTask
{
    public class Interactor : IInputPort
    {
        private readonly IRepository<Entities.Todo.Task> _repository;

        public OutputDataResponse Response { get; set; }

        public Interactor(IRepository<Entities.Todo.Task> repository)
        {
            _repository = repository;
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

            Response = new OutputDataResponse
            {
                Subject = input.Subject,
                Description = input.Description,
                CreatedAt = DateTime.Now,
                CompletedAt = null
            };
        }
    }
}
