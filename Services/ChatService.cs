using Microsoft.AspNetCore.SignalR;

namespace iMate.API.Services
{
    public class ChatService : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"Message received from {user}: {message}");
            await Clients.All.SendAsync("ReceiveMessage", "Bot", "Hello");
        }

        public override async Task OnConnectedAsync()
        {
            Console.WriteLine($"Client {Context.ConnectionId} connected");
            await Clients.All.SendAsync("ReceivedMessage", "Bot", "Hi");
            // You can store connection ID or perform actions upon connection
        }

    }
}
