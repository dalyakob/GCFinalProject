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
            return View(model.data.ElementAt(0));
        }

        // GET: TripAdvisorController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TripAdvisorController1/Create
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

        // GET: TripAdvisorController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TripAdvisorController1/Edit/5
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

        // GET: TripAdvisorController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TripAdvisorController1/Delete/5
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
