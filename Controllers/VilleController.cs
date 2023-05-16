using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projet.Model;
using projet.data;

namespace projet.Controllers
{
    public class VilleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VilleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ville
        public async Task<IActionResult> Index()
        {
              return _context.Ville != null ? 
                          View(await _context.Ville.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Ville'  is null.");
        }

        // GET: Ville/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ville == null)
            {
                return NotFound();
            }

            var ville = await _context.Ville
                .FirstOrDefaultAsync(m => m.idVille == id);
            if (ville == null)
            {
                return NotFound();
            }

            return View(ville);
        }

        // GET: Ville/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ville/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idVille,nomVille,codePostal")] Ville ville)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ville);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ville);
        }

        // GET: Ville/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ville == null)
            {
                return NotFound();
            }

            var ville = await _context.Ville.FindAsync(id);
            if (ville == null)
            {
                return NotFound();
            }
            return View(ville);
        }

        // POST: Ville/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idVille,nomVille,codePostal")] Ville ville)
        {
            if (id != ville.idVille)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ville);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VilleExists(ville.idVille))
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
            return View(ville);
        }

        // GET: Ville/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ville == null)
            {
                return NotFound();
            }

            var ville = await _context.Ville
                .FirstOrDefaultAsync(m => m.idVille == id);
            if (ville == null)
            {
                return NotFound();
            }

            return View(ville);
        }

        // POST: Ville/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ville == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ville'  is null.");
            }
            var ville = await _context.Ville.FindAsync(id);
            if (ville != null)
            {
                _context.Ville.Remove(ville);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VilleExists(int id)
        {
          return (_context.Ville?.Any(e => e.idVille == id)).GetValueOrDefault();
        }
    }
}
