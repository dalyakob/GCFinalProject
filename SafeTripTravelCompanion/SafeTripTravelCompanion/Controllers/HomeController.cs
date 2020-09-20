using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeTripTravelCompanion.Data;
using SafeTripTravelCompanion.Models;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IQuestionaireService _service;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IQuestionaireService service, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _service = service;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                RedirectToAction("AuthorizedIndex");
            return View();
        }

        public async Task<IActionResult> AuthorizedIndex()
        {
            var userId = _userManager.GetUserId(User);
            var questionaire = _context.Questionaire.Where(x => x.User.Id == userId);



            return View(questionaire);
            // return View(_service.QuestionaireSelector());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
