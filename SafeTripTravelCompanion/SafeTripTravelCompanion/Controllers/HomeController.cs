using System.Diagnostics;
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
        private readonly IQuestionaireService _questionaireService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITripAdvisorService _tripAdvisorService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ITripAdvisorService tripAdvisorService, IQuestionaireService questionaireService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _questionaireService = questionaireService;
            _userManager = userManager;
            _tripAdvisorService = tripAdvisorService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                RedirectToAction("AuthorizedIndex");
            return View();
        }

        public IActionResult AuthorizedIndex()
        {
            var userId = _userManager.GetUserId(User);
            var questionaire = _context.Questionaire.Find(userId);
            
            //            return two searches                   return two random searchable strings from user questionaire
            var model = _tripAdvisorService.GetTwoLocations(_questionaireService.QuestionaireSelector(questionaire));

            return View(model);

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
