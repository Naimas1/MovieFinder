using Microsoft.AspNetCore.Identity;

public class Review
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public required Movie Movie { get; set; }
    public required string UserId { get; set; }
    public required IdentityUser User { get; set; }
    public required string Content { get; set; }
    public int Rating { get; set; } // Рейтинг от 1 до 5
    public DateTime CreatedAt { get; internal set; }
}
