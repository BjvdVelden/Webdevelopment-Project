using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ApplicationUser
        public async Task<IActionResult> IndexUser()
        {
            return View(await _context.AppUsers.Where(x => x.UserName.Contains("assistent")).ToListAsync());
        }
        

        // GET: ApplicationUser/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.AppUsers.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            return View(applicationUser);
        }

    
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Voornaam,Achternaam,GeboorteDatum,Postcode,Huisnummer,VoogdEmail,HulpverlenerEmail,Reden,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser applicationUser)
        {
                    
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                { 

                    var koppelingDB = new assistentHulpverlenerKoppel {mailHulpverlener = applicationUser.HulpverlenerEmail, mailAssistent= applicationUser.Email};
                    _context.Add(koppelingDB);
                    _context.SaveChanges();
                    int koppelId = koppelingDB.idKoppel -1 ;
                    assistentHulpverlenerKoppel assistent =  _context.assistentHulpverlenerKoppel.Find(koppelId);
                    _context.Remove(assistent);
                    _context.SaveChanges();


                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(applicationUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("IndexUser");
            }
            return View(applicationUser);
        }


        private bool ApplicationUserExists(string id)
        {
            return _context.AppUsers.Any(e => e.Id == id);
        }
    }
}
