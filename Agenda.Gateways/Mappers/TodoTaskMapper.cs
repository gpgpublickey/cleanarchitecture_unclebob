namespace Agenda.Gateways.Mappers
{
    public static class TodoTaskMapper
    {
        public static PersistenceEntities.Task ToPersistenceEntity(Entities.Todo.Task task)
        {
            return new PersistenceEntities.Task
            {
                Id = 0,
                Subject = task.Subject,
                Description = task.Description,
                DueDate = task.DueDate,
                Timestamp = null
            };
        }

        public static Entities.Todo.Task ToDomainEntity(PersistenceEntities.Task task)
        {
            return new Entities.Todo.Task
            {
                Subject = task.Subject,
                Description = task.Description,
                DueDate = task.DueDate
            };
        }
    }
}
