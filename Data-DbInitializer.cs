public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        if (context.Genres.Any())
        {
            return;   // База данных инициализирована
        }

        var genres = new Genre[]
        {
            new Genre{Name="Action"},
            new Genre{Name="Comedy"},
            new Genre{Name="Drama"},
            new Genre{Name="Animation"},
            new Genre{Name="Horror"}
        };

        context.Genres.AddRange(genres);
        context.SaveChanges();

        var movies = new Movie[]
        {
            new Movie{Title ="Inception",Rating = 8.8,GenreId = 1},
            new Movie{Title="The Dark Knight",Rating=9.0,GenreId=1},
            new Movie{Title="Shrek",Rating=7.8,GenreId=4},
            new Movie{Title="The Lion King",Rating=8.5,GenreId=4},
            new Movie{Title="Parasite",Rating=8.6,GenreId=3},
            new Movie{Title="The Conjuring",Rating=7.5,GenreId=5},
            new Movie{ Title = "The Hangover", Rating = 7.7, GenreId = 2 }
        };

        context.Movies.AddRange(movies);
        context.SaveChanges();
    }
}
