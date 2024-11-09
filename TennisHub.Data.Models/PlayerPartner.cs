
namespace TennisHub.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;


    [PrimaryKey(nameof(PlayerId), nameof(PartnerId))]
    public class PlayerPartner
    {
        public Guid PlayerId { get; set; }
        public Player Player { get; set; } = null!;

        public Guid PartnerId { get; set; }

        [ForeignKey(nameof(PartnerId))]
        public Player Partner { get; set; } = null!;
    }
}