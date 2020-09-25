using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeTripTravelCompanion.Data;
using SafeTripTravelCompanion.Models.DataBase;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion.Controllers
{
    [Authorize]
    public class BucketListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITripAdvisorService _tripAdvisorService;
        private readonly UserManager<IdentityUser> _userManager;

        public BucketListController(ApplicationDbContext context, ITripAdvisorService tripAdvisorService, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _tripAdvisorService = tripAdvisorService;
            _userManager = userManager;
        }

        // GET: BucketLists
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var model = await _tripAdvisorService.GetBucketList(await _context.BucketLists.Where(m => m.User.Id == userId).ToListAsync());

            return View(model);
        }

        // POST: BucketLists/Create
        public async Task<IActionResult> Create(string id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            await _context.AddAsync(new BucketList { LocationID = id, User = currentUser });
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        // GET: BucketLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = _userManager.GetUserId(User);
            var bucketList = await _context.BucketLists.FirstOrDefaultAsync(m => m.LocationID == id && m.User.Id == userId);
            if (bucketList == null)
            {
                return NotFound();
            }

            return View(bucketList);
        }

        // POST: BucketLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bucketList = await _context.BucketLists.FirstOrDefaultAsync(m => m.LocationID == id);
            _context.BucketLists.Remove(bucketList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BucketListExists(string id)
        {
            return _context.BucketLists.Any(e => e.LocationID == id);
        }
    }
}
