using JOKES.Data;

namespace JOKES.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IJokeRepo Jokes { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Jokes = (IJokeRepo)new JokeImplement(_dbContext);
            //Jokes = jokes;
        }
        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
