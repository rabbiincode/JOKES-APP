using JOKES.Models;

namespace JOKES.Repository
{
    public interface IJokeRepo
    {
        Task<Joke> GetJokeAsync(int id);

        Task<IEnumerable<Joke>> GetAllJokesAsync();

        Task<bool> AddAsync(Joke joke);

        Task<bool> AddRangeAsync(IEnumerable<Joke> jokes);

        Task<bool> UpsertAsync(Joke joke);
        Task<IEnumerable<Joke>> SearchAsync(string word);

        Task<bool> DeleteAsync(int id);
    }
}
