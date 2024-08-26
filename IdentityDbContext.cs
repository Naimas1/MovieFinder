using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;
using static MovieFinder.IdentityDbContext;

namespace MovieFinder
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>, IEquatable<IdentityDbContext?>, IIdentityDbContext
    {
        public interface IIdentityDbContext
        {
            bool Equals(IdentityDbContext? other);
            bool Equals(object? obj);
        }

        private IdentityDbContext _add1;

        internal void SetAdd1(IdentityDbContext value)
        {
            _add1 = value;
        }


        public override bool Equals(object? obj)
        {
            return Equals(obj as IdentityDbContext);
        }

        public bool Equals(IdentityDbContext? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   EqualityComparer<DatabaseFacade>.Default.Equals(Database, other.Database) &&
                   EqualityComparer<ChangeTracker>.Default.Equals(ChangeTracker, other.ChangeTracker) &&
                   EqualityComparer<IModel>.Default.Equals(Model, other.Model) &&
                   EqualityComparer<DbContextId>.Default.Equals(ContextId, other.ContextId) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<ApplicationUser>>.Default.Equals(Users, other.Users) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityUserClaim<string>>>.Default.Equals(UserClaims, other.UserClaims) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityUserLogin<string>>>.Default.Equals(UserLogins, other.UserLogins) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityUserToken<string>>>.Default.Equals(UserTokens, other.UserTokens) &&
                   EqualityComparer<Version>.Default.Equals(SchemaVersion, other.SchemaVersion) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityUserRole<string>>>.Default.Equals(UserRoles, other.UserRoles) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityRole>>.Default.Equals(Roles, other.Roles) &&
                   EqualityComparer<Microsoft.EntityFrameworkCore.DbSet<IdentityRoleClaim<string>>>.Default.Equals(RoleClaims, other.RoleClaims) &&
                   EqualityComparer<IdentityDbContext>.Default.Equals(_context, other._context) &&
                   EqualityComparer<DbContextOptions<IdentityDbContext>>.Default.Equals(_options, other._options);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Database);
            hash.Add(ChangeTracker);
            hash.Add(Model);
            hash.Add(ContextId);
            hash.Add(Users);
            hash.Add(UserClaims);
            hash.Add(UserLogins);
            hash.Add(UserTokens);
            hash.Add(SchemaVersion);
            hash.Add(UserRoles);
            hash.Add(Roles);
            hash.Add(RoleClaims);
            hash.Add(_add1);
            hash.Add(_context);
            hash.Add(_options);
            return hash.ToHashCode();
        }

        private readonly IdentityDbContext _context;
        private readonly DbContextOptions<IdentityDbContext> _options;

        public IdentityDbContext(DbContextOptions options) : base(options)
        {
        }

        protected IdentityDbContext()
        {
        }

        public static bool operator ==(IdentityDbContext? left, IdentityDbContext? right)
        {
            return EqualityComparer<IdentityDbContext>.Default.Equals(left, right);
        }

        public static bool operator !=(IdentityDbContext? left, IdentityDbContext? right)
        {
            return !(left == right);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

    public class ApplicationUser
    {
    }
}
