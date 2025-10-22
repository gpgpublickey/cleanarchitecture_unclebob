namespace Agenda.UseCases.Todo.AddTodoTask.Models
{
    public class OutputDataResponse
    {
        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? CompletedAt { get; set; }
    }
}
