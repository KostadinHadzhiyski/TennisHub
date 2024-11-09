

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TennisHub.Data.Models;

namespace TennisHub.Data.Configurations
{
    public class UserPartnerConfiguration : IEntityTypeConfiguration<UserPartner>
    {
        public void Configure(EntityTypeBuilder<UserPartner> builder)
        {
            builder
               .HasKey(up => new { up.UserId, up.PartnerId });

            builder
                .HasOne(up => up.User)
                .WithMany(u => u.Partners)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
