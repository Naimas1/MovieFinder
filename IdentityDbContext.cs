using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieFinder
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        internal IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
        }

        internal void SetAdd1(IdentityDbContext value)
        {
            Add1 = value;
        }

        private readonly IdentityDbContext _context;
        private readonly DbContextOptions<IdentityDbContext> _options;
    }

    public class ApplicationUser
    {
    }
}
