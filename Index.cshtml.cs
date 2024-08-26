using System.Diagnostics;
using System.IO;

namespace MovieFinder
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Programs
    {
        static void Main()
        {
            using (StreamWriter streamwriter = new StreamWriter(@"D:\index.html"))
            {
                streamwriter.WriteLine("<html>");
                streamwriter.WriteLine("<head>");
                streamwriter.WriteLine("  <title>Movie Search</title>");
                streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
                streamwriter.WriteLine("  <style>");
                streamwriter.WriteLine("    body { font-family: Arial, sans-serif; margin: 0; padding: 0; background-color: #f4f4f4; }");
                streamwriter.WriteLine("    .search-bar { padding: 20px; background-color: #333; color: white; text-align: center; }");
                streamwriter.WriteLine("    .search-bar input[type='text'] { padding: 10px; width: 60%; border: none; }");
                streamwriter.WriteLine("    .search-bar button { padding: 10px 20px; background-color: #f39c12; border: none; color: white; cursor: pointer; }");
                streamwriter.WriteLine("    .movie-section { padding: 20px; }");
                streamwriter.WriteLine("    .movie-grid { display: grid; grid-template-columns: repeat(auto-fill, minmax(200px, 1fr)); gap: 20px; }");
                streamwriter.WriteLine("    .movie-item { background-color: white; padding: 10px; text-align: center; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }");
                streamwriter.WriteLine("    .movie-item img { width: 100%; height: auto; }");
                streamwriter.WriteLine("  </style>");
                streamwriter.WriteLine("</head>");
                streamwriter.WriteLine("<body>");
                streamwriter.WriteLine("  <div class=\"search-bar\">");
                streamwriter.WriteLine("    <input type=\"text\" placeholder=\"Search for movies...\">");
                streamwriter.WriteLine("    <button>Search</button>");
                streamwriter.WriteLine("  </div>");
                streamwriter.WriteLine("  <section class=\"movie-section\">");
                streamwriter.WriteLine("    <h2>Trending Movies</h2>");
                streamwriter.WriteLine("    <div class=\"movie-grid\">");
                streamwriter.WriteLine("      <div class=\"movie-item\">");
                streamwriter.WriteLine("        <img src=\"https://via.placeholder.com/200x300\" alt=\"Movie Poster\">");
                streamwriter.WriteLine("        <h3>Movie Title 1</h3>");
                streamwriter.WriteLine("        <p>Rating: 8.5</p>");
                streamwriter.WriteLine("      </div>");
                streamwriter.WriteLine("      <!-- Add more movie items here -->");
                streamwriter.WriteLine("    </div>");
                streamwriter.WriteLine("  </section>");
                streamwriter.WriteLine("</body>");
                streamwriter.WriteLine("</html>");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}