

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace TennisHub.Data.Models
{
    [PrimaryKey(nameof(UserId), nameof(FriendId))]
    public class UserFriend
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public Guid FriendId { get; set; }

        [ForeignKey(nameof(FriendId))]
        public ApplicationUser Friend { get; set; } = null!;
    }
}
