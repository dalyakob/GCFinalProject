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
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetCovidRate(string state)
        {
            ViewBag.State = state;
            return View(await _covidTrackingService.GetCovidRate(state));
        }

        // GET: CovidTrackingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CovidTrackingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CovidTrackingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidTrackingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CovidTrackingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidTrackingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CovidTrackingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
