using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TennisHub.Data.Models;

namespace TennisHub.Web.Data
{
    public class TennisHubDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public TennisHubDbContext(DbContextOptions<TennisHubDbContext> options)
            : base(options)
        {
        }
    }
}
