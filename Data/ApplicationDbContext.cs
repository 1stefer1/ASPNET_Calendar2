using ASPNET_Calendar2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_Calendar2.Data
{
    public class ApplicationDbContext : IdentityDbContext/*<ApplicationUser> из-за этой штуки ошибка*/
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; } 

    }
}