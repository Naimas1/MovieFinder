public class MovieApiService
{
    private readonly HttpClient _client;

    public MovieApiService(HttpClient client)
    {
        _client = client;
    }

    public async Task<MovieApiResult> GetMovieDataAsync(string movieTitle)
    {
        var response = await _client.GetAsync($"https://api.themoviedb.org/3/search/movie?api_key=YOUR_API_KEY&query={movieTitle}");
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsAsync<MovieApiResult>();
        return result;
    }
}

public class MovieApiResult
{
    public required List<MovieApiData> Results { get; set; }
}

public class MovieApiData
{
    public required string Title { get; set; }
    public double Rating { get; set; }
    public string Overview { get; set; }
    public string PosterPath { get; set; }
}
