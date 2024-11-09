
namespace TennisHub.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Security.Claims;
    using TennisHub.Data.Models;
    using TennisHub.Web.Data;
    using TennisHub.Web.ViewModels.Player;

    public class UserController : Controller
    {
        private TennisHubDbContext data;

        public UserController(TennisHubDbContext dbContext)
        {
            data = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserDetails()
        {
            ViewData["Title"] = "User details:";
            ApplicationUser? currentUser = await data.Users
                .FirstOrDefaultAsync(u => u.Id == GetUserId());
            
            if(currentUser == null)
            {
                return BadRequest();
            }

            PlayerDetailsViewModel userDetails = new PlayerDetailsViewModel()
            {

                Email = currentUser.Email!,
                PhoneNumber = currentUser.PhoneNumber ?? string.Empty,
            };
            
            return View(userDetails);
        }

        private Guid GetUserId() 
        {
            Guid result = new Guid();
            string? userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId != null) 
            { 
                result = Guid.Parse(userId);    
            }

            return result;
        }
    }
}
