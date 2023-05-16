using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projet.data;

namespace projet.Controllers
{
    public class ActiviteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActiviteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Activite
        public async Task<IActionResult> Index()
        {
              return _context.Actiivte != null ? 
                          View(await _context.Actiivte.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Actiivte'  is null.");
        }

        // GET: Activite/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Actiivte == null)
            {
                return NotFound();
            }

            var activite = await _context.Actiivte
                .FirstOrDefaultAsync(m => m.idActivite == id);
            if (activite == null)
            {
                return NotFound();
            }

            return View(activite);
        }

        // GET: Activite/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Activite/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idActivite,heureDebut,heureFin,date,descriptionAct,nomActivite")] Activite activite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activite);
        }

        // GET: Activite/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Actiivte == null)
            {
                return NotFound();
            }

            var activite = await _context.Actiivte.FindAsync(id);
            if (activite == null)
            {
                return NotFound();
            }
            return View(activite);
        }

        // POST: Activite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idActivite,heureDebut,heureFin,date,descriptionAct,nomActivite")] Activite activite)
        {
            if (id != activite.idActivite)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActiviteExists(activite.idActivite))
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
            return View(activite);
        }

        // GET: Activite/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Actiivte == null)
            {
                return NotFound();
            }

            var activite = await _context.Actiivte
                .FirstOrDefaultAsync(m => m.idActivite == id);
            if (activite == null)
            {
                return NotFound();
            }

            return View(activite);
        }

        // POST: Activite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Actiivte == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Actiivte'  is null.");
            }
            var activite = await _context.Actiivte.FindAsync(id);
            if (activite != null)
            {
                _context.Actiivte.Remove(activite);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActiviteExists(int id)
        {
          return (_context.Actiivte?.Any(e => e.idActivite == id)).GetValueOrDefault();
        }
    }
}
