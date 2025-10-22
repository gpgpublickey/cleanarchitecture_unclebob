namespace Agenda.UseCases.Interfaces
{
    public interface IPort<T>
    {
        void Handle(T input);

        Task HandleAsync(T input);
    }
}
