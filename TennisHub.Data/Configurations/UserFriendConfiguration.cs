
namespace TennisHub.Data.Configurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TennisHub.Data.Models;

    public class UserFriendConfiguration : IEntityTypeConfiguration<UserFriend>
    {
        public void Configure(EntityTypeBuilder<UserFriend> builder)
        {
            builder
                .HasKey(uf => new { uf.UserId, uf.FriendId });

            builder
                .HasOne(x => x.User)
                .WithMany(u => u.Friends)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
