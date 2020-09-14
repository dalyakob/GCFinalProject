using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion.Controllers
{
    public class CovidTrackingController : Controller
    {
        private readonly ICovidTrackingService _covidTrackingService;

        public CovidTrackingController(ICovidTrackingService covidTrackingService)
        {
            _covidTrackingService = covidTrackingService;
        }
        // GET: CovidTrackingController
        public async Task<ActionResult> GetCovidRate(string state)
        {
            ViewBag.State = state;
            return View(await _covidTrackingService.GetCovidRate(state));
        }
    }
}
