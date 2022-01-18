using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Webdevelopment_Project.Hubs{
public class ChatHub : Hub
{
    public async Task SendMessage(Message message) =>
        await Clients.All.SendAsync("receiveMessage", message);
}
}