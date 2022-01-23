using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;
using Microsoft.AspNetCore.Identity;

namespace Webdevelopment_Project.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public ClientController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager , UserManager<ApplicationUser> userManager )
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

    public async Task<IActionResult> ChatFrequentie()
        {
            var user = await _userManager.GetUserAsync(User);
            
            ViewData["naamClient"] = _context.Users.Where(v=>v.VoogdEmail == user.Email).SingleOrDefault().Voornaam;
            var clientmail = _context.Users.Where(v=>v.VoogdEmail == user.Email).SingleOrDefault().Email;
            var ChatFrequentieClient = _context.Messages.Where(c=>c.UserName == clientmail);
            ViewData["AantalBerichten"] = _context.Messages.Where(c=>c.UserName == clientmail).Count();
            return View(await ChatFrequentieClient.ToListAsync());
        }
     
    }
}
