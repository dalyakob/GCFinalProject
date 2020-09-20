using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeTripTravelCompanion.Data;
using SafeTripTravelCompanion.Models.DataBase;

namespace SafeTripTravelCompanion.Controllers
{
    public class QuestionairesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public QuestionairesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Questionaires
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            //await _context.Questionaire.Where(x => x.User.Id == userId).Include(x.User).ToListAsync()
            return View(await _context.Questionaire.Where(x => x.User.Id == userId).ToListAsync());
        }

        // GET: Questionaires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionaire = await _context.Questionaire
                .FirstOrDefaultAsync(m => m.QuestionaireID == id);
            if (questionaire == null)
            {
                return NotFound();
            }

            return View(questionaire);
        }

        // GET: Questionaires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Questionaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionaireID,Answer1,Answer2,Answer3")] Questionaire questionaire)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                questionaire.User = currentUser;

                _context.Questionaire.Add(questionaire);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(questionaire);
        }

        // GET: Questionaires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionaire = await _context.Questionaire.FindAsync(id);
            if (questionaire == null)
            {
                return NotFound();
            }
            return View(questionaire);
        }

        // POST: Questionaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionaireID,Answer1,Answer2,Answer3")] Questionaire questionaire)
        {
            if (id != questionaire.QuestionaireID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionaire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionaireExists(questionaire.QuestionaireID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(questionaire);
        }

        // GET: Questionaires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionaire = await _context.Questionaire
                .FirstOrDefaultAsync(m => m.QuestionaireID == id);
            if (questionaire == null)
            {
                return NotFound();
            }

            return View(questionaire);
        }

        // POST: Questionaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionaire = await _context.Questionaire.FindAsync(id);
            _context.Questionaire.Remove(questionaire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionaireExists(int id)
        {
            return _context.Questionaire.Any(e => e.QuestionaireID == id);
        }
    }
}
