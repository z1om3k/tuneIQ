namespace tuneIQ.Core.Models
{
    public class GameSession
    {
        public Guid Id { get; set; }
        public List<Guid> PlayerIds { get; set; } = new List<Guid>();
        public GameState State { get; set; } = GameState.MainMenu;
    }
}
