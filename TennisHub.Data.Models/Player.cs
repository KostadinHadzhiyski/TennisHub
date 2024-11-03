
namespace TennisHub.Data.Models
{

    using System.ComponentModel.DataAnnotations;
    using TennisHub.Data.Models.Enumerations;

    using static TennisHub.Data.Models.ModelsValidationConstants.Player;

    public class Player : ApplicationUser
    {
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

        public int? Weigth { get; set; }

        public int? Height { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; } = DateTime.UtcNow;

        public ICollection<MatchType> PrefferedMatchesTypes { get; set; } = new HashSet<MatchType>();

        public ICollection<PlayerPartner> Partners { get; set; } = new HashSet<PlayerPartner>();
        public ICollection<Player> Friends { get; set; } = new HashSet<Player>();

    }
}
