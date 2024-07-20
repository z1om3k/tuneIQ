using tuneIQ.Core.Models;

namespace tuneIQ.Core.Interfaces.Services
{
   public interface IGameSessionService
   {
       Task<GameSession> CreateSessionAsync();
       Task AddPlayerToSessionAsync(Guid sessionId, string playerId);
       Task<GameSession> GetSessionAsync(Guid sessionId);
   }
}
