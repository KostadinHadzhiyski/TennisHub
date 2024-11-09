
namespace TennisHub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations.Schema;


    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid(); 
        }

        public Player? Player { get; set; }

        public ICollection<UserFriend> Friends { get; set; } = new HashSet<UserFriend>();

    }
}
