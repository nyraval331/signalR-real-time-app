using System.Threading.Tasks;

namespace SignalR_Demo.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
