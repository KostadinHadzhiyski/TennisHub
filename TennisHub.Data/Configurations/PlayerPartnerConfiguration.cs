

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TennisHub.Data.Models;

namespace TennisHub.Data.Configurations
{
    public class PlayerPartnerConfiguration : IEntityTypeConfiguration<PlayerPartner>
    {
        public void Configure(EntityTypeBuilder<PlayerPartner> builder)
        {
            builder
               .HasKey(up => new { up.PlayerId, up.PartnerId });

            builder
                .HasOne(pp => pp.Player)
                .WithMany(p => p.Partners)
                .HasForeignKey(x => x.PartnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
