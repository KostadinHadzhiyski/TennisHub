
namespace TennisHub.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TennisHub.Data.Models.Enumerations;
    using static TennisHub.Common.EntityValidationConstants.Player;

    public class Player
    {


        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;


        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }


        [Required]
        public PlayerLevel Level { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; } = DateTime.UtcNow;

        public int? Weigth { get; set; }

        public int? Height { get; set; }

        public StrikeType? Forehand { get; set; }

        public StrikeType? Backhand { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }


        public ICollection<MatchType> PrefferedMatchesTypes { get; set; } = new HashSet<MatchType>();

   
        public ICollection<PlayerPartner> Partners { get; set; } = new HashSet<PlayerPartner>();


    }
}
