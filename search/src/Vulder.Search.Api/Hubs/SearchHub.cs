using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Vulder.Search.Core.Services;

namespace Vulder.Search.Api.Hubs
{
    [Authorize]
    public class SearchHub : Hub
    {
        private readonly SchoolsCollectionService _schoolsCollection;
        private List<string> Connections { get; set; }
        public SearchHub(SchoolsCollectionService schoolsCollection)
        {
            _schoolsCollection = schoolsCollection;
            Connections = new List<string>();
        }

        public override Task OnConnectedAsync()
        {
            Connections.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public async Task SendPrivateMessage(string user, string input)
        {
            if (Connections.Exists(x => x.Equals(user)))
                await Clients.User(user).SendAsync("response", await _schoolsCollection.Get(input));
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Connections.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}