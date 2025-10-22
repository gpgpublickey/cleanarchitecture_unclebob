using Agenda.Gateways.Mappers;
using Agenda.UseCases.Interfaces;

namespace Agenda.EntityFramework.Sqlite.Repositories
{
    internal class TaskRepository : IRepository<Entities.Todo.Task>
    {
        private readonly AgendaDbContext _db;

        public TaskRepository(AgendaDbContext agendaDbContext)
        {
            _db = agendaDbContext;
        }

        public async Task<Entities.Todo.Task> Add(Entities.Todo.Task item)
        {
            var record = await _db.Tasks.AddAsync(TodoTaskMapper.ToPersistenceEntity(item));
            await _db.SaveChangesAsync();

            return TodoTaskMapper.ToDomainEntity(record.Entity);
        }
    }
}
