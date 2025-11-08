using Agenda.Presenters.AddTodoTask;
using Agenda.UseCases.Todo.AddTodoTask.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Controllers
{
    public static class RegisterServices
    {
        public static IServiceCollection AddTodoUseCase(this IServiceCollection services)
        {
            services.AddTransient<IInputPort, UseCases.Todo.AddTodoTask.Interactor>();
            services.AddScoped<AddBrowserPresenter>();
            services.AddScoped<IOutputPort>(sp => sp.GetRequiredService<AddBrowserPresenter>());
            services.AddTransient<TodoTasksController>();
            return services;
        }
    }
}
