using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.Presenters.Todo
{
    public class BrowserViewModel
    {
        public BrowserViewModel(OutputDataResponse response)
        {
            Description = response.Description;
            Title = response.Subject;
            CompletedAt = response.CompletedAt;
            IsDue = response.CompletedAt.HasValue && response.CompletedAt.Value < DateTime.Now;
        }

        public bool IsDue { get; internal set; }

        public DateTime? CompletedAt { get; internal set; }

        public string Description { get; internal set; }

        public string Title { get; internal set; }
    }
}
