using JOKES.Data;
using JOKES.Models;
using Microsoft.EntityFrameworkCore;

namespace JOKES.Repository
{
    public class JokeImplement : IJokeRepo
    {
        private readonly ApplicationDbContext _dbContext;

        protected DbSet<Joke> dbSet;

        public JokeImplement(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = dbContext.Set<Joke>();
        }

        public async Task<Joke> GetJokeAsync(int id)
        {
            return await dbSet.Where(joke => joke.Id == id)?.FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Joke>> GetAllJokesAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<bool> AddAsync(Joke joke)
        {
            await dbSet.AddAsync(joke);
            return true;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<Joke> jokes)
        {
            await dbSet.AddRangeAsync();
            return true;
        }

        public async Task<bool> UpsertAsync(Joke joke)
        {
            var row = await dbSet.Where(jokeId => jokeId.Id == joke.Id).FirstOrDefaultAsync();

            row.Question = joke.Question;
            row.Answer = joke.Answer;

            return true;
        }

        public async Task<IEnumerable<Joke>> SearchAsync(string word)
        {
            return await dbSet.Where(search => search.Question.Contains(word)).ToListAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var delete = await dbSet.Where(joke => joke.Id == id).FirstOrDefaultAsync();
            dbSet.Remove(delete);

            return true;
        }
    }
}
