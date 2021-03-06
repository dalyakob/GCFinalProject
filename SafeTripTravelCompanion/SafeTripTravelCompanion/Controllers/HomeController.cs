﻿using System.Diagnostics;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITripAdvisorService _tripAdvisorService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ITripAdvisorService tripAdvisorService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _tripAdvisorService = tripAdvisorService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("AuthorizedIndex");
            return View();
        }

        public async Task<IActionResult> AuthorizedIndex()
        {
            var userId = _userManager.GetUserId(User);
            var userQuestionaire = _context.Questionaire.FirstOrDefault(m => m.User.Id == userId);
            var questionaireList = _tripAdvisorService.QuestionaireSelector(userQuestionaire);

            //            return two searches                   return two random searchable strings from user questionaire
            var model = await _tripAdvisorService.GetTwoLocations(questionaireList);

            return View(model);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
