﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SafeTripTravelCompanion.Data;
using SafeTripTravelCompanion.Models.DataBase;
using SafeTripTravelCompanion.Models.TripAdvisor.Attraction;
using SafeTripTravelCompanion.Models.TripAdvisor.Location;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion.Controllers
{
    [Authorize]
    public class BucketListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITripAdvisorService _tripAdvisorService;

        public BucketListController(ApplicationDbContext context, ITripAdvisorService tripAdvisorService)
        {
            _context = context;
            _tripAdvisorService = tripAdvisorService;
        }

        // GET: BucketLists
        public async Task<IActionResult> Index()
        {
            var bucketList = await _context.BucketLists.ToListAsync();

            var model = await _tripAdvisorService.GetBucketList(bucketList);

            return View(model);
        }

        // GET: BucketLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bucketList = await _context.BucketLists
                .FirstOrDefaultAsync(m => m.LocationID == id);

            if (bucketList == null)
            {
                return NotFound();
            }

            return View(bucketList);
        }

        // POST: BucketLists/Create
        public async Task<IActionResult> Create(string id)
        {
            var bucketList = new BucketList { LocationID = id };
            if (ModelState.IsValid)
            {
                _context.Add(bucketList);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: BucketLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bucketList = await _context.BucketLists.FindAsync(id);

            if (bucketList == null)
            {
                return NotFound();
            }

            return View(bucketList);
        }

        // POST: BucketLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BucketListId")] BucketList bucketList)
        {
            if (id != bucketList.LocationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bucketList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BucketListExists(bucketList.LocationID))
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
            return View(bucketList);
        }

        // GET: BucketLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bucketList = await _context.BucketLists
                .FirstOrDefaultAsync(m => m.LocationID == id);
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