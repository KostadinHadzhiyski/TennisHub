
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisHub.Data.Models
{
    [PrimaryKey(nameof(PlayerId), nameof(PartnerId))]
    public class PlayerPartner
    {
        public Guid PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;

        public Guid PartnerId { get; set; }
        [ForeignKey(nameof(PartnerId))]
        public Player Partner { get; set; } = null!;

        public DateTime PartnersFrom { get; set; } = DateTime.UtcNow;
    }
}
