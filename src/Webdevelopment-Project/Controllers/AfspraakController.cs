using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Controllers
{
    public class AfspraakController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        
        public AfspraakController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }

        // GET: Afspraak
        public async Task<IActionResult> IndexAfspraak()
        {
            var currentUser =await _userManager.GetUserAsync(User);
            var rol = await _userManager.GetRolesAsync(currentUser);
            if (rol.Contains("Client"))
            {
                return View(await _context.Afspraak.Where(c => c.ClientEmail == currentUser.Email).ToListAsync());
            }
            return View(await _context.Afspraak.Where(b => b.HulpverlenerEmail == currentUser.Email).ToListAsync());
        }

        public async Task<bool> AccesCheckAsync(Afspraak afspraak)
        {   
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            string emailUser = await _userManager.GetEmailAsync(currentUser);

            if (emailUser == afspraak.HulpverlenerEmail || emailUser == afspraak.ClientEmail)
            {
                return true;
            }
            return false;
        }

        // GET: Afspraak/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afspraak = await _context.Afspraak
                .FirstOrDefaultAsync(m => m.AfspraakId == id);
            if (afspraak == null)
            {
                return NotFound();
            }

            return View(afspraak);
        }

        // GET: Afspraak/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Afspraak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AfspraakId,ClientEmail,HulpverlenerEmail,Start,Eind,Onderwerp,GoedkeuringVoogd")] Afspraak afspraak)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser client = await _userManager.FindByEmailAsync(afspraak.ClientEmail);

                _context.Add(afspraak);
                await _context.SaveChangesAsync();

                 if (client.getLeeftijd() >= 16 || afspraak.GoedkeuringVoogd)
                {
                    afspraak.GoedkeuringVoogd = true;
                }
                else 
                {   
                    var afspraakid = _context.Afspraak.Where(afs => afs.ClientEmail == afspraak.ClientEmail && afs.HulpverlenerEmail == afspraak.HulpverlenerEmail && afs.Start == afspraak.Start && afs.Eind == afspraak.Eind).FirstOrDefault().AfspraakId;
                    
                    Melding melding  = new Melding
                    {
                        Ontvanger = client.VoogdEmail,
                        Type = "AfspraakVoogd",
                        Titel = "Nieuwe Afspraak van " + client.Voornaam,
                        Datum = DateTime.Now,
                        IsAfgehandeld = false,
                        Inhoud = client.Voornaam + " heeft een afspraak gemaakt met zijn behandelaar voor " + afspraak.Start + " tot " + afspraak.Eind,
                        AfsrpaakId = afspraakid
                    };

                    _context.Melding.Add(melding);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(afspraak);
        }


        // GET: Afspraak/Edit/5
         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afspraak = await _context.Afspraak.FindAsync(id);
            if (afspraak == null)
            {
                return NotFound();
            }
            if (await AccesCheckAsync(afspraak))
            {
                return View(afspraak);
            }
            
            return View("NoAcces");
        }
        // POST: Afspraak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AfspraakId,ClientEmail,HulpverlenerEmail,Start,Eind,Onderwerp,GoedkeuringVoogd")] Afspraak afspraak)
        {
            if (id != afspraak.AfspraakId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afspraak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfspraakExists(afspraak.AfspraakId))
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
       
            return View(afspraak);
        }

        // GET: Afspraak/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afspraak = await _context.Afspraak
                .FirstOrDefaultAsync(m => m.AfspraakId == id);
            if (afspraak == null)
            {
                return NotFound();
            }

            return View(afspraak);
        }

        // POST: Afspraak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var afspraak = await _context.Afspraak.FindAsync(id);
            _context.Afspraak.Remove(afspraak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfspraakExists(int id)
        {
            return _context.Afspraak.Any(e => e.AfspraakId == id);
        }
    }
}
