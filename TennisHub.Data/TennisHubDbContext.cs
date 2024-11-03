
namespace TennisHub.Web.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using TennisHub.Data.Models;

    public class TennisHubDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {

        public TennisHubDbContext(DbContextOptions<TennisHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserFriend> UsersFriends { get; set; }
        public DbSet<UserPartner> UsersPartners { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserFriend>()
                .HasKey(uf => new { uf.UserId, uf.FriendId });

            builder.Entity<UserFriend>()
                .HasOne(x => x.User)
                .WithMany(u => u.Friends)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserPartner>()
               .HasKey(up => new { up.UserId, up.PartnerId });

            builder.Entity<UserPartner>()
                .HasOne(up => up.User)
                .WithMany(u => u.Partners)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        //public DbSet<UserPartner> UsersPartners { get; set; }
        //public DbSet<UserFriend> UsersFriends { get; set; }

    }
}
