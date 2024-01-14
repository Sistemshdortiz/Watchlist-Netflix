using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WatchlistNetflix_V2.Context;
using WatchlistNetflix_V2.Data;

namespace WatchlistNetflix_V2.Controllers
{
    public class WatchlistsController : Controller
    {
        private readonly AplicationDbContext _context;

        public WatchlistsController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Watchlists
        public async Task<IActionResult> Index()
        {
              return _context.Watchlists != null ? 
                          View(await _context.Watchlists.ToListAsync()) :
                          Problem("Entity set 'AplicationDbContext.Watchlists'  is null.");
        }

        // GET: Watchlists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Watchlists == null)
            {
                return NotFound();
            }

            var watchlist = await _context.Watchlists
                .FirstOrDefaultAsync(m => m.WatchlistId == id);
            if (watchlist == null)
            {
                return NotFound();
            }

            return View(watchlist);
        }

        // GET: Watchlists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Watchlists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WatchlistId,NombreLista")] Watchlist watchlist)
        {
            // Obtener el ID del usuario actual
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // Asignar el usuario solo si está autenticado y se obtuvo el ID
            watchlist.User = User.Identity.IsAuthenticated && userId != null
                ? await _context.Users.FindAsync(userId)
                : null;      
                _context.Add(watchlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
        }

        // GET: Watchlists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Watchlists == null)
            {
                return NotFound();
            }

            var watchlist = await _context.Watchlists.FindAsync(id);
            if (watchlist == null)
            {
                return NotFound();
            }
            return View(watchlist);
        }

        // POST: Watchlists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WatchlistId,NombreLista")] Watchlist watchlist)
        {
            if (id != watchlist.WatchlistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(watchlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WatchlistExists(watchlist.WatchlistId))
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
            return View(watchlist);
        }

        // GET: Watchlists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Watchlists == null)
            {
                return NotFound();
            }

            var watchlist = await _context.Watchlists
                .FirstOrDefaultAsync(m => m.WatchlistId == id);
            if (watchlist == null)
            {
                return NotFound();
            }

            return View(watchlist);
        }

        // POST: Watchlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Watchlists == null)
            {
                return Problem("Entity set 'AplicationDbContext.Watchlists'  is null.");
            }
            var watchlist = await _context.Watchlists.FindAsync(id);
            if (watchlist != null)
            {
                _context.Watchlists.Remove(watchlist);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WatchlistExists(int id)
        {
          return (_context.Watchlists?.Any(e => e.WatchlistId == id)).GetValueOrDefault();
        }
    }
}
