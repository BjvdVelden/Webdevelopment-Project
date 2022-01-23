﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Webdevelopment_Project.Hubs
{
    public class ChatHub : Hub
    {
        public Task JoinRoom(string roomId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, roomId);
        }

        public Task LeaveRoom(string roomId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId);
        }

        public string GetConnectionId() => Context.ConnectionId;
    }
}