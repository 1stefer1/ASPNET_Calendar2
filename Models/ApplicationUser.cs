using Microsoft.AspNetCore.Identity;

namespace ASPNET_Calendar2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Event> Events { get; set; }
    }
}
