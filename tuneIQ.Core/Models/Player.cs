namespace tuneIQ.Core.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Score { get; set; } = 0;
    }
}
