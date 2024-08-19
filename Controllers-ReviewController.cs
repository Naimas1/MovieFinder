using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class ReviewController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public ReviewController(AppDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public AppDbContext Get_context()
    {
        return _context;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(int movieId, string content, int rating, AppDbContext _context)
    {
        var review = new Review
        {
            MovieId = movieId,
            Content = content,
            Rating = rating,
            UserId = _userManager.GetUserId(User),
            CreatedAt = DateTime.Now
        };
        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();

        return RedirectToAction("Details", "Movie", new { id = movieId });
    }
}
