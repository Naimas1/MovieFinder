using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieFinder;
public class ReviewController : Controller, IEquatable<ReviewController?>
{
    private readonly AppDbContext _context;

    public ReviewController(UserManager<ApplicationUser> userManager, AppDbContext context)
    {
        _context = context;
        this.UserManager = userManager;
    }

    public UserManager<ApplicationUser> UserManager { get; }

    public Task<IActionResult> AddReview(Review newReview)
    {
        return AddReview(newReview, _context);
    }

    public async Task<IActionResult> AddReview(Review newReview, AppDbContext _context)
    {
        if (ModelState.IsValid)
        {   
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(newReview);
    }

    public bool Equals(ReviewController? other)
    {
        throw new NotImplementedException();
    }
}
