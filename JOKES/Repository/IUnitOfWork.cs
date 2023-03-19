namespace JOKES.Repository
{
    public interface IUnitOfWork
    {
        IJokeRepo Jokes { get; }

        Task CompleteAsync();
    }
}
