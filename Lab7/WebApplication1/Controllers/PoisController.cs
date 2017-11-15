using System;
using System.Threading.Tasks;
using Business;
using Data.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class PoisController : Controller
    {
        private readonly IPoiRepository _context;

        public PoisController(IPoiRepository context)
        {
            _context = context;
        }

        // GET: Cities
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }

        // GET: Cities/Details/5
        public IActionResult Details(Guid id)
        {
            var poi = _context.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // GET: Cities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Descrition,Latitude,Longitude")] Poi poi)
        {
            if (ModelState.IsValid)
            {
                poi.Id = Guid.NewGuid();
                _context.Add(poi);
                return RedirectToAction(nameof(Index));
            }
            return View(poi);
        }

        // GET: Cities/Edit/5
        public IActionResult Edit(Guid id)
        {
            var poi = _context.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }
            return View(poi);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Name,Descrition,Latitude,Longitude")] Poi poi)
        {
            if (id != poi.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(poi);
            try
            {
                _context.Edit(poi);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(poi.Id))
                {
                    return NotFound();
                }
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Cities/Delete/5
        public IActionResult Delete(Guid id)
        {
            var poi = _context.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(Guid id)
        {
            if (_context.GetById(id) != null)
                return true;
            return false;
        }
    }
}

