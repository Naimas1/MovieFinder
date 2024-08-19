
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}

public class DbSet<T>
{
    internal void AddRange(Genre[] genres)
    {
        throw new NotImplementedException();
    }

    internal void AddRange(Movie[] movies)
    {
        throw new NotImplementedException();
    }

    internal bool Any()
    {
        throw new NotImplementedException();
    }

    internal object Include(Func<object, object> value)
    {
        throw new NotImplementedException();
    }

    internal object Select(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}

public class DbContextOptions<T>
{
}

public class DbContext
{
    private DbContextOptions<AppDbContext> options;

    public DbContext(DbContextOptions<AppDbContext> options)
    {
        this.options = options;
    }
    public DbSet<Review> Reviews { get; set; }
}