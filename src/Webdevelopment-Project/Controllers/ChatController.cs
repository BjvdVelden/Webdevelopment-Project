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

namespace Webdevelopment_Project.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly IChatRepository _repo;
        private readonly ApplicationDbContext _context;


        public ChatController(IChatRepository repo, ApplicationDbContext context){
            _repo = repo;
            _context = context;
        }
        public IActionResult CreateRoom()
        {
            var chats = _repo.GetChats(GetUserId());

            return View(chats);
        }

        public IActionResult FindUser()
        {
            var users = _context.Users.Where(x => x.Id != User.GetUserId()).ToList();

            return View(users);
        }

        public async Task<IActionResult> Index(string onderwerp, int leeftijd)
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

        public IActionResult Private()
        {
            var chats = _repo.GetPrivateChats(GetUserId()).Take(1);

            return View(chats);
        }

        public async Task<IActionResult> CreatePrivateRoom(string userId)
        {
            var id = await _repo.CreatePrivateRoom(GetUserId(), userId);

            return RedirectToAction("Chat", new { id });
        }

        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {
            return View(_repo.GetChat(id));
        }

        // [HttpPost]
        // public async Task<IActionResult> CreateRoom(string name, int minimumAge, int maximumAge)
        // {
        //     await _repo.CreateRoom(name, minimumAge,maximumAge, GetUserId());
        //     return RedirectToAction("Index");
        // }

        // [HttpPost]
        // public async Task<IActionResult> DeleteRoom(string name)
        // {
        //     await _repo.DeleteRoom(name, GetUserId());
        //     return RedirectToAction("Index");
        // }

        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            await _repo.JoinRoom(id, GetUserId());

            return RedirectToAction("Chat", "Chat", new { id = id });
        }

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
        
        // public async Task<IActionResult> MisbruikMelden(int chatId, string roomName)
        // {

        //     var message = new Message {
        //         ChatId = chatId,
        //         Name = "er is misbruik gemeld bij de kamer",
        //         Text = roomName,
        //         Timestamp = DateTime.Now,
        //         TypMessage = "abuse"
        //     };

        //     _context.Messages.Add(message);
        //     await _context.SaveChangesAsync();

        //     return RedirectToAction("Chat", new {id = chatId});
        // }

        // public async Task<IActionResult> GebruikerBlokkeren(string userId)
        // {
        //     _context.ChatUsers.FirstOrDefault(a => a.UserId == userId).blocked = !_context.ChatUsers.FirstOrDefault(a => a.UserId == userId).blocked;
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction("Index");
        // }
    }
}