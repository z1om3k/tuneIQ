namespace tuneIQ.Core.Interfaces.Services
{
    public interface IWebSocketConnection
    {
        Task SendAsync(string message);
        Task CloseAsync(string message);
    }
}
