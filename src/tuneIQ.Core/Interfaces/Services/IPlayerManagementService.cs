using tuneIQ.Core.Models;

namespace tuneIQ.Core.Interfaces.Services
{
    public interface IPlayerManagementService
    {
        Task<Player> CreatePlayerAsync(string name);
        Task<Player> GetPlayerAsync(Guid id);
        Task UpdatePlayerScoreAsync(Guid id, int newScore);
    }
}
