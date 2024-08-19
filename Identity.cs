using System.IO.Packaging;

namespace MovieFinder
{
    public class Identity
    {
        dotnet add private readonly Package microsoft.AspNetCore.Identity.EntityFrameworkCore { get; set; }

        private Package EntityFrameworkCore()
        {
            return microsoft.AspNetCore.Identity.EntityFrameworkCore;
        }
    }

    internal class dotnet
    {
    }
}
