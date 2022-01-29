using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;

// [Authorize]
public class MeldingController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    
    public MeldingController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    private async Task<bool> AllowAccesMeldingAsync(Melding melding)
    {
        
        ApplicationUser currentUser = await _userManager.GetUserAsync(User);
        return (currentUser.Email == melding.Ontvanger);
    }

    public async Task<IActionResult> IndexAsync(int? pagina)
    {   
        ApplicationUser currentUser = await _userManager.GetUserAsync(User);
        IQueryable<Melding> meldingen = _context.Melding.Where(m => m.Ontvanger == currentUser.Email).Where(n => !n.IsAfgehandeld).OrderBy(d => d.Datum);

        
        return View(meldingen);

    }

    public async Task<IActionResult> DetailsAsync(string id)
    {
        var melding = _context.Melding.Where(m => m.MeldingId == int.Parse(id)).FirstOrDefault();
        if (await AllowAccesMeldingAsync(melding))
        {
            return View(melding);
        }
        return RedirectToAction("Index", "GeenToegang");
    }

    public async Task<IActionResult> GoedkeurenAsync(string id, bool goedgekeurd)
    {
        var melding = _context.Melding.Where(m => m.MeldingId == int.Parse(id)).FirstOrDefault();
        if (await AllowAccesMeldingAsync(melding))
        {
            //Code om afspraak goed te keuren
            var afspraak = _context.Afspraak.Where(af => af.AfspraakId == melding.AfsrpaakId).FirstOrDefault();
            afspraak.GoedkeuringVoogd = goedgekeurd;

            if(!goedgekeurd)
            {
            Melding behandelaarMelding = new Melding
            {
                Datum = DateTime.Now,
                Type = "VoogdNietGoedgekeurd",
                Ontvanger = afspraak.HulpverlenerEmail,
                Titel = "Afspraak met client niet goedgekeurd",
                AfsrpaakId = afspraak.AfspraakId,
                Inhoud = "Afspraak met " + afspraak.ClientEmail + " is niet goedgekeurd door voogd",
                IsAfgehandeld = false
            };
                _context.Add(behandelaarMelding);
            }
        
            melding.IsAfgehandeld = true;
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> BegrepenAsync(string id)
    {
        var melding = _context.Melding.Where(m => m.MeldingId == int.Parse(id)).FirstOrDefault();
        if (await AllowAccesMeldingAsync(melding))
        {
            melding.IsAfgehandeld = true;
            await _context.SaveChangesAsync();
        }   
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> BekijkenAsync(string melding, string aanmelding)
    {
        var m = _context.Melding.Where(m => m.MeldingId == int.Parse(melding)).FirstOrDefault();
        if (await AllowAccesMeldingAsync(m))
        {
            m.IsAfgehandeld = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Aanmelding", new { id = aanmelding});
        }  

        return RedirectToAction("Index", "GeenToegang");
    }}