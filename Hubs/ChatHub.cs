using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userId, string message)
        {
            
            await Clients.All.SendAsync("ReceiveMessage", userId, message);
        // }
        // public override Task OnConnected()  
        // {  
        // ConnectedUser.Ids.Add(Context.ConnectionId);  
        // return base.OnConnected();  
        // }  
        // public override Task OnDisconnected()  
        // {  
        // ConnectedUser.Ids.Remove(Context.ConnectionId);  
        // return base.OnDisconnected();  
        // }  
        //   }  
        //     }
        // }
        // public static class ConnectedUser  
        // {  
        // public static List<string> Ids = new List<string>();  

        // public Task OnConnected(){

        // }
        }        }}