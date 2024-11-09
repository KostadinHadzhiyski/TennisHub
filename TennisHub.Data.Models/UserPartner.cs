
namespace TennisHub.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;


    [PrimaryKey(nameof(UserId), nameof(PartnerId))]
    public class UserPartner
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public Guid PartnerId { get; set; }

        [ForeignKey(nameof(PartnerId))]
        public ApplicationUser Partner { get; set; } = null!;
    }
}