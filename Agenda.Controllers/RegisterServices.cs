using Agenda.Presenters.Todo;
using Agenda.UseCases.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Controllers
{
    public static class RegisterServices
    {
        public static IServiceCollection AddTodoUseCase(this IServiceCollection services)
        {
            services.AddTransient<IInputPort, UseCases.Todo.AddTodoTask.Interactor>();
            services.AddTransient<IOutputPort<BrowserViewModel>, BrowserPresenter>();
            services.AddTransient<TodosController>();
            return services;
        }
    }
}
