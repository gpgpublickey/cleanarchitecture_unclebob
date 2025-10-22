namespace Agenda.UseCases.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Add(T item);
    }
}
