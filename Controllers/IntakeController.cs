using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Models;
using Webdevelopment_Project.Data;
using System;

namespace Webdevelopment_Project.Controllers
{
    public class IntakeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IntakeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
         // GET: Aanmelding
        [Authorize (Roles = "Hulpverlener")]
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            return View(await _context.Intake.Where(b => b.GewensteHulpverlener == currentUser.Email).Where(af => af.IsAfgehandeld == false).ToListAsync());
        }

        // GET: Aanmelding/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intake = await _context.Intake
                .FirstOrDefaultAsync(m => m.IntakeId == id);
            if (intake == null)
            {
                return NotFound();
            }

            return View(intake);
        }
    // GET: Aanmelding/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aanmelding/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AanmeldingId,Voornaam,Achternaam,GeboorteDatum,BSN,Email,GewensteBehandelaar,GewensteMoment,Onderwerp")] Intake intake)
        {
            if (ModelState.IsValid)
            {
                intake.AanmaakDatum = DateTime.Now;
                intake.IsAfgehandeld = false;
                _context.Add(intake);
                _context.SaveChanges();
                
                var intake1id = _context.Intake.Where(aan => aan.BSN == intake.BSN).OrderByDescending(d => d.AanmaakDatum).FirstOrDefault().IntakeId;
                Melding melding  = new Melding
                    {
                        Ontvanger = intake.GewensteHulpverlener,
                        Type = "AanmeldingHulpverlener",
                        Titel = "Nieuwe Aanmelding van " + intake.Voornaam + " " + intake.Achternaam,
                        Datum = DateTime.Now,
                        IsAfgehandeld = false,
                        Inhoud = intake.Voornaam + " " + intake.Achternaam + " heeft zich aangemeld voor u",
                        AfsrpaakId = intake1id
                    };
                _context.Melding.Add(melding);
                


                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(intake);
        }
          public async Task<IActionResult> GoedkeurenAsync(int? id) 
        {
            var intake = await _context.Intake.FindAsync(id);
            intake.IsAfgehandeld = true;
            _context.SaveChanges();

            // Stuur email etc.
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AfwijzenAsync(int? id) 
        {
            var intake = await _context.Intake.FindAsync(id);
            intake.IsAfgehandeld = true;
            return RedirectToAction("Index");
        }
    }
}
        