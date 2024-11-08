﻿
namespace TennisHub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using TennisHub.Data.Models.Enumerations;
    using static TennisHub.Data.Models.ModelsValidationConstants.Player;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid(); 
        }

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

        //public ICollection<ApplicationUser> Friends { get; set; } = new HashSet<ApplicationUser>();
        //public ICollection<ApplicationUser> Partners { get; set; } = new HashSet<ApplicationUser>();


        public ICollection<UserFriend> Friends { get; set; } = new HashSet<UserFriend>();
        public ICollection<UserPartner> Partners { get; set; } = new HashSet<UserPartner>();
    }
}
