using tuneIQ.Core.Interfaces.Services;

namespace tuneIQ.Services.Websockets
{
    public class WebSocketConnectionManager : IWebSocketConnectionManager
    {
        private readonly Dictionary<Guid, IWebSocketConnection> _connections = new();

        public void AddConnectionAsync(Guid playerId, IWebSocketConnection connection)
        {
            _connections[playerId] = connection;
        }
    }
}
