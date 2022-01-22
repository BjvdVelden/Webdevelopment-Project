using System.Collections.Generic;
using System.Threading.Tasks;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Infrastructure.Respository
{
    public interface IChatRepository
    {
        Chat GetChat(int id);
        Task CreateRoom(string name, int minimumAge, int maximumAge, string userId);
        // Task DeleteRoom(string name, string userId);
        Task JoinRoom(int chatId, string userId);
        IEnumerable<Chat> GetChats(string userId);
        Task<int> CreatePrivateRoom(string rootId, string targetId);
        IEnumerable<Chat> GetPrivateChats(string userId);

        Task<Message> CreateMessage(int chatId, string message, string userId);
    }
}