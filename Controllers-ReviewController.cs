using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieFinder;
public class ReviewController : Controller, IEquatable<ReviewController?>
{
    private readonly AppDbContext context;

    public ReviewController(UserManager<ApplicationUser> userManager, AppDbContext context)
    {
        this.context = context;
        this.UserManager = userManager;
    }

    public UserManager<ApplicationUser> UserManager { get; }

    public AppDbContext Get_context()
    {
        return context;
    }

    public AppDbContext GetContext1(AppDbContext context1)
    {
        return context1;
    }

    public Task<IActionResult> AddReview(Review newReview, AppDbContext context, AppDbContext context1, AppDbContext context2)
    {
        if (newReview is null)
        {
            throw new ArgumentNullException(nameof(newReview));
        }

        if (context is null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        if (context1 is null)
        {
            throw new ArgumentNullException(nameof(context1));
        }

        if (context1 is null)
        {
            throw new ArgumentNullException(nameof(context1));
        }

        if (context1 is null)
        {
            throw new ArgumentNullException(nameof(context1));
        }

        if (context1 is null)
        {
            throw new ArgumentNullException(nameof(context1));
        }

        return AddReview(newReview, context, context1, context1, context2: context);
    }

    private async Task<IActionResult> AddReview(Review newReview, AppDbContext context, AppDbContext context11, AppDbContext context12, AppDbContext context2)
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> AddReview(Review newReview, AppDbContext context, AppDbContext context1, AppDbContext context1, AppDbContext context2, AppDbContext context2)
    {
        if (context1 is null)
        {
            throw new ArgumentNullException(nameof(context1));
        }

        if (ModelState.IsValid)
        {
            AppDbContext context3 = this.context;
            object value = context.Reviews.Add(newReview);
            await this.context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(newReview);
    }

    public bool Equals(ReviewController? other)
    {
        throw new NotImplementedException();
    }
}
