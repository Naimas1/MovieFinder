public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public double Rating { get; set; }
    public int GenreId { get; set; }
    public required Genre Genre { get; set; }
}
