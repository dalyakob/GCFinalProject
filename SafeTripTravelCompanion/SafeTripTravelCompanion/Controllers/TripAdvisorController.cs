using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion.Controllers
{
    public class TripAdvisorController : Controller
    {
        private readonly ITripAdvisorService _tripAdvisorService;

        public TripAdvisorController(ITripAdvisorService tripAdvisorService)
        {
            _tripAdvisorService = tripAdvisorService;
        }
        // GET: TripAdvisorController1
        public async Task<ActionResult> Index(string search)
        {
            ViewBag.Search = search;
            var model = await _tripAdvisorService.GetLocation(search);
            return View(model.data);
        }

        // GET: TripAdvisorController1/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _tripAdvisorService.Get(id);
            return View(model.data.FirstOrDefault());
        }

        // GET: TripAdvisorController1/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
