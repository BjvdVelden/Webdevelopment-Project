using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Hubs;
using Webdevelopment_Project.Infrastructure;
using Webdevelopment_Project.Infrastructure.Respository;
using Webdevelopment_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Webdevelopment_Project.Controllers
{
    // [Authorize]
    public class ChatController : Controller
    {
        private readonly IChatRepository _repo;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public ChatController(IChatRepository repo, ApplicationDbContext context, UserManager<ApplicationUser> userManager){
            _repo = repo;
            _context = context;
            _userManager = userManager;

        }

        // [Authorize(Roles="Hulpverlener")] 
        public IActionResult CreateRoom()
        {
            var chats = _repo.GetChats(GetUserId());

            return View(chats);
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        public async Task<IActionResult> FindUserAsync()
        {
            var users = _context.Users.Where(x => x.Id != User.GetUserId()).ToList();
                
                return View(users);
         
        }
        

        // [Authorize(Roles="Hulpverlener, Client")] 
        public async Task<IActionResult> FindGroup(string onderwerp, int leeftijd)
        {
            ViewData["onderwerp"] = onderwerp;
            ViewData["leeftijd"] = leeftijd;
            if (onderwerp == null){
                if(leeftijd == 0){
                    return View(await _context.Chats.ToListAsync());
                }
                return View(await _context.Chats.Where(A => A.MaximumAge >= leeftijd && A.MinimumAge <= leeftijd).ToListAsync());
                } 
            if(leeftijd == 0){
                    return View(await _context.Chats.Where(A => A.Name.ToLower().Replace(" ", "").Contains(onderwerp.ToLower().Replace(" ", ""))).ToListAsync());
                }

            return View(await _context.Chats.Where(x => x.Type == ChatType.Room).Where(A => A.Name.ToLower().Replace(" ", "").Contains(onderwerp.ToLower().Replace(" ", "")) && A.MaximumAge <= leeftijd && A.MinimumAge >= leeftijd).ToListAsync());
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        public IActionResult Private()
        {
            var chats = _repo.GetPrivateChats(GetUserId());

            return View(chats);
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        public async Task<IActionResult> CreatePrivateRoom(string userId)
        {
            var id = await _repo.CreatePrivateRoom(GetUserId(), userId);

            return RedirectToAction("Chat", new { id });
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {
            return View(_repo.GetChat(id));
        }

        // [Authorize(Roles = "Hulpverlener")]
        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name, int minimumAge, int maximumAge)
        {
            await _repo.CreateRoom(name, minimumAge,maximumAge, GetUserId());
            return RedirectToAction("FindGroup");
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            await _repo.JoinRoom(id, GetUserId());

            return RedirectToAction("Chat", "Chat", new { id = id });
        }

        // [Authorize(Roles="Hulpverlener, Client")] 
        public async Task<IActionResult> SendMessage(
            int roomId,
            string message,
            [FromServices] IHubContext<ChatHub> chat)
        {
            var Message = await _repo.CreateMessage(roomId, message, User.Identity.Name);

            await chat.Clients.Group(roomId.ToString())
                .SendAsync("RecieveMessage", new
                {
                    Text = Message.Text,
                    Name = Message.UserName,
                    Timestamp = Message.When.ToString("dd/MM/yyyy hh:mm:ss")
                });

            return Ok();
        }
        
        public string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}