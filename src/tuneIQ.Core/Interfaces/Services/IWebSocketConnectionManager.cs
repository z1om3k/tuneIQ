namespace tuneIQ.Core.Interfaces.Services
{
    public interface IWebSocketConnectionManager
    {
       void AddConnectionAsync(Guid playerId, IWebSocketConnection connection);
       // Task RemoveConnectionAsync(Guid playerId);
       // Task SendToAsync(string playerId, string message);
       // Task BroadcastAsync(string message);
    }
}
