using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Webdevelopment_Project.Infrastructure.Respository
{
    public class ChatRepository : IChatRepository
    {
        private ApplicationDbContext _context;

        public ChatRepository(ApplicationDbContext context) => _context = context;

        public async Task<Message> CreateMessage(int chatId, string message, string userId)
        {
            var Message = new Message
            {
                ChatId = chatId,
                Text = message,
                UserName = userId,
                When = DateTime.Now
            };

            _context.Messages.Add(Message);
            await _context.SaveChangesAsync();

            return Message;
        }

        public async Task<int> CreatePrivateRoom(string rootId, string targetId)
        {
            var chat = new Chat
            {
                Type = ChatType.Private
            };

            chat.Users.Add(new ChatUser
            {
                UserId = targetId
            });

            chat.Users.Add(new ChatUser
            {
                UserId = rootId
            });

            _context.Chats.Add(chat);

            await _context.SaveChangesAsync();

            return chat.Id;
        }

        public async Task CreateRoom(string name, int minimumAge, int maximumAge, string userId)
        {
            var chat = new Chat
            {
                Name = name,
                MinimumAge = minimumAge,
                MaximumAge = maximumAge,
                Type = ChatType.Room
            };

            chat.Users.Add(new ChatUser
            {
                UserId = userId
            });

            _context.Chats.Add(chat);

            await _context.SaveChangesAsync();
        }

        public Chat GetChat(int id)
        {
            return _context.Chats
                .Include(x => x.Messages)
                .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Chat> GetChats(string userId)
        {
            return _context.Chats
                .Include(x => x.Users)
                .Where(x => !x.Users
                    .Any(y => y.UserId == userId))
                .ToList();
        }

        public IEnumerable<Chat> GetPrivateChats(string userId)
        {
            return _context.Chats
                   .Include(x => x.Users)
                       .ThenInclude(x => x.User)
                   .Where(x => x.Type == ChatType.Private
                       && x.Users
                           .Any(y => y.UserId == userId))
                   .ToList();
        }

        public async Task JoinRoom(int chatId, string userId)
        {
            var chatUser = new ChatUser
            {
                ChatId = chatId,
                UserId = userId
            };

            _context.ChatUsers.Add(chatUser);

            await _context.SaveChangesAsync();
        }

        Task IChatRepository.FindGroup(string onderwerp, int leeftijd)
        {
            throw new NotImplementedException();
        }
    }
}