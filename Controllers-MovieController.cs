using Microsoft.AspNetCore.Mvc;

public class MovieController : Controller
{
    private readonly MovieApiService _movieApiService;

    public MovieController(MovieApiService movieApiService)
    {
        _movieApiService = movieApiService;
    }

    public async Task<IActionResult> Search(string title)
    {
        var movies = await _movieApiService.GetMovieDataAsync(title);
        return View(movies);
    }
}
