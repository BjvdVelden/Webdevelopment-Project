using System;
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



// Alleen toegankelijk voor Moderators

namespace Webdevelopment_Project.Controllers
{
    public class ModeratorController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;


        public ModeratorController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> IndexModerator()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.HulpverlenerEmail = user.HulpverlenerEmail;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }

        public async Task<IActionResult> Relatie()
        {
             var currentUser =await _userManager.GetUserAsync(User);
             
            var rol = await _userManager.GetRolesAsync(currentUser);
            if (rol.Contains("Client"))
            {
                return View(await _context.Afspraak.Where(c => c.ClientEmail == currentUser.Email).ToListAsync());
            }
            return View(await _context.Afspraak.Where(b => b.HulpverlenerEmail == currentUser.Email).ToListAsync());
        }


        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.userId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user.UserName;
            var model = new List<ModeratorEditModel>();
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new ModeratorEditModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Manage(List<ModeratorEditModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View();
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            return RedirectToAction("IndexModerator");
        }

    [HttpGet]
        public async Task<IActionResult> Blokkeren()
        {
            
            if(!await _roleManager.RoleExistsAsync("Zelfhulpgroep_ban"))
            {
                await _roleManager.CreateAsync(new IdentityRole{Name = "Zelfhulpgroep_ban"});
            }
            var _users = await _userManager.GetUsersInRoleAsync("Client");
            var _blokt = await _userManager.GetUsersInRoleAsync("Zelfhulpgroep_ban");
            ViewData["blockt"] = _blokt.ToList();
            return View(_users);
        }
        [HttpPost]
        public async Task<IActionResult> Blokkeren(string Id)
        {   
            
            var _user = _context.AppUsers.SingleOrDefault(_user => _user.Id == Id);
            var _bloktUser = await _userManager.GetUsersInRoleAsync("Zelfhulpgroep_ban");
            
            if (_bloktUser.Any(_user => _user.Id == Id))
            {
                await _userManager.RemoveFromRoleAsync(_user ,"Zelfhulpgroep_ban");
            }else
            {
                await _userManager.AddToRoleAsync(_user, "Zelfhulpgroep_ban");
            }
           
            return Redirect("Blokkeren");
        }

    }
}