﻿
namespace TennisHub.Web.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    using TennisHub.Data.Models;

    public class TennisHubDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {

        public TennisHubDbContext(DbContextOptions<TennisHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserFriend> UsersFriends { get; set; }
        public DbSet<PlayerPartner> UsersPartners { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);

            builder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }

    }
}
