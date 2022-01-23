using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Data;

namespace Webdevelopment_Project.Controllers
{
    public class BehandelingController : Controller
    {   
        private readonly ApplicationDbContext _context;

        public BehandelingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles="Hulpverlener, Moderator")] 
        // GET: Behandeling
        public async Task<IActionResult> IndexBehandeling()
        {
            var applicationDbContext = _context.Behandeling.Include(b => b.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles="Hulpverlener")] 
        // GET: Behandeling/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var behandeling = await _context.Behandeling
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (behandeling == null)
            {
                return NotFound();
            }

            return View(behandeling);
        }

        [Authorize(Roles="Hulpverlener")] 
        // GET: Behandeling/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserID"] = new SelectList(_context.AppUsers, "Id", "Id");
            return View();
        }

        [Authorize(Roles="Hulpverlener")] 
        // POST: Behandeling/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Omschrijving,Datum,Email,ApplicationUserID")] Behandeling behandeling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(behandeling);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexBehandeling");
            }
            ViewData["ApplicationUserID"] = new SelectList(_context.AppUsers, "Id", "Id", behandeling.ApplicationUserID);
            return View(behandeling);
        }

        [Authorize(Roles="Hulpverlener")] 
        // GET: Behandeling/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var behandeling = await _context.Behandeling.FindAsync(id);
            if (behandeling == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserID"] = new SelectList(_context.AppUsers, "Id", "Id", behandeling.ApplicationUserID);
            return View(behandeling);
        }

        [Authorize(Roles="Hulpverlener")] 
        // POST: Behandeling/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Omschrijving,Datum,Email,ApplicationUserID")] Behandeling behandeling)
        {
            if (id != behandeling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(behandeling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BehandelingExists(behandeling.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("IndexBehandeling");
            }
            ViewData["ApplicationUserID"] = new SelectList(_context.AppUsers, "Id", "Id", behandeling.ApplicationUserID);
            return View(behandeling);
        }

        [Authorize(Roles="Hulpverlener")] 
        // GET: Behandeling/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var behandeling = await _context.Behandeling
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (behandeling == null)
            {
                return NotFound();
            }

            return View(behandeling);
        }

        [Authorize(Roles="Hulpverlener")] 
        // POST: Behandeling/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var behandeling = await _context.Behandeling.FindAsync(id);
            _context.Behandeling.Remove(behandeling);
            await _context.SaveChangesAsync();
            return RedirectToAction("IndexBehandeling");
        }

        private bool BehandelingExists(int id)
        {
            return _context.Behandeling.Any(e => e.Id == id);
        }
    }
}
