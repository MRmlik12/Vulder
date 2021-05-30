using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Vulder.Search.Api.Hubs
{
    public class SearchHub : Hub
    {
        public async Task SendMessage(string content)
        {
            
        }
    }
}