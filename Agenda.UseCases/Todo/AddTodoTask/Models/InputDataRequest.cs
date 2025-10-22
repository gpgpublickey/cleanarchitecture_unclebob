namespace Agenda.UseCases.Todo.AddTodoTask.Models
{
    public class InputDataRequest
    {
        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }
    }
}
