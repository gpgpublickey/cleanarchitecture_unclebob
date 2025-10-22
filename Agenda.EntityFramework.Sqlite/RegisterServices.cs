using Agenda.UseCases.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Task = Agenda.Gateways.PersistenceEntities.Task;

namespace Agenda.EntityFramework.Sqlite
{
    public static class RegisterServices
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AgendaDbContext>(ServiceLifetime.Scoped);
            services.AddScoped<IRepository<Entities.Todo.Task>, Repositories.TaskRepository>();
        }
    }
}