using JOKES.Models;
using JOKES.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JOKES.Controllers
{
    public class JokesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public JokesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Jokes
        public async Task<IActionResult> Index()
        {
            return View(await unitOfWork.Jokes.GetAllJokesAsync());
        }

        // GET: Jokes/Search 
        public IActionResult Search()
        {
            return View();
        }

        // POST: Jokes/SearchResult
        public async Task<IActionResult> SearchResults(string SearchPhrase)
        {
            IEnumerable<Joke> list = await unitOfWork.Jokes.SearchAsync(SearchPhrase);
            return View("Index", list);
        }

        // GET: Jokes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var joke = await unitOfWork.Jokes.GetJokeAsync(id);
            
            if (joke == null)
            {
                return NotFound();
            }

            return View(joke);
        }

        // GET: Jokes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jokes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Question,Answer")] Joke joke)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Jokes.AddAsync(joke);
                await unitOfWork.CompleteAsync();
                TempData["success"] = "Joke created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(joke);
        }

        // GET: Jokes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var joke = await unitOfWork.Jokes.GetJokeAsync(id);

            if (joke == null)
            {
                return NotFound();
            }
            return View(joke);
        }

        // POST: Jokes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,Answer")] Joke joke)
        {
            if (id != joke.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await unitOfWork.Jokes.UpsertAsync(joke);
                    await unitOfWork.CompleteAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JokeExists(joke.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["success"] = "Joke edited successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(joke);
        }

        // GET: Jokes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var joke = await unitOfWork.Jokes.GetJokeAsync(id);
            
            if (joke == null)
            {
                return NotFound();
            }

            return View(joke);
        }

        // POST: Jokes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joke = await unitOfWork.Jokes.GetJokeAsync(id);

            if (joke != null)
            {
                await unitOfWork.Jokes.DeleteAsync(id);
            }

            await unitOfWork.CompleteAsync();
            TempData["success"] = "Joke deleted successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool JokeExists(int id)
        {
            return unitOfWork.Jokes.GetJokeAsync(id) != null ? true : false;
        }
    }
}
