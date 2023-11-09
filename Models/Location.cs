using System.ComponentModel.DataAnnotations;

namespace ASPNET_Calendar2.Models
{
    public class Location
    {
        [Key]
        public int key { get; set; }
        public string name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
