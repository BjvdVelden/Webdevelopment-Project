using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Controllers
{
    public class HulpverlenerController : Controller
    {
        private readonly MyContext _context;

        public HulpverlenerController(MyContext context)
        {
            _context = context;
        }

        // GET: Hulpverlener
        public async Task<IActionResult> Index()
        {
            return View(await _context.HulpverlenerModel.ToListAsync());
        }

        // GET: Hulpverlener/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hulpverlenerModel = await _context.HulpverlenerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hulpverlenerModel == null)
            {
                return NotFound();
            }

            return View(hulpverlenerModel);
        }

        // GET: Hulpverlener/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hulpverlener/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naam,Geboortedatum,Telefoonnummer,Emailadres,Specialisme,moderator,ClientID,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] HulpverlenerModel hulpverlenerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hulpverlenerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hulpverlenerModel);
        }

        // GET: Hulpverlener/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hulpverlenerModel = await _context.HulpverlenerModel.FindAsync(id);
            if (hulpverlenerModel == null)
            {
                return NotFound();
            }
            return View(hulpverlenerModel);
        }

        // POST: Hulpverlener/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Naam,Geboortedatum,Telefoonnummer,Emailadres,Specialisme,moderator,ClientID,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] HulpverlenerModel hulpverlenerModel)
        {
            if (id != hulpverlenerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hulpverlenerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HulpverlenerModelExists(hulpverlenerModel.Id))
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
            return View(hulpverlenerModel);
        }

        // GET: Hulpverlener/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hulpverlenerModel = await _context.HulpverlenerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hulpverlenerModel == null)
            {
                return NotFound();
            }

            return View(hulpverlenerModel);
        }

        // POST: Hulpverlener/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hulpverlenerModel = await _context.HulpverlenerModel.FindAsync(id);
            _context.HulpverlenerModel.Remove(hulpverlenerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HulpverlenerModelExists(string id)
        {
            return _context.HulpverlenerModel.Any(e => e.Id == id);
        }
    }
}
